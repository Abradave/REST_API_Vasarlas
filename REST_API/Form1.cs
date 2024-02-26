using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using REST_API;
using Newtonsoft.Json;
using System.IO;

namespace REST_API
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointURL");

        private static string ReadSetting(string keyName)
        {
            string result = null;
            try
            {
                var value = ConfigurationManager.AppSettings;
                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaFrissites();
        }

        private async void listaFrissites()
        {
            listBoxVasarlasok.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var vasarlas = Vasarlas.FromJson(jsonString);
                    foreach ( Vasarlas item in vasarlas )
                    {
                        listBoxVasarlasok.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void listBoxVasarlasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vasarlas vasarlo = (Vasarlas)listBoxVasarlasok.SelectedItem;
            textBoxId.Text = vasarlo.Id.ToString();
            textBoxName.Text = vasarlo.Name;
            dateTimePickerDate.Value = DateTime.Parse(vasarlo.Date);
            nuPayment.Value = vasarlo.Payment;
            comboBoxGender.Text = vasarlo.Gender;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            listaFrissites();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Vasarlas vasarlo = new Vasarlas();
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Név megadása kötelező");
                textBoxName.Focus();
                return;
            }
            //Többi ellenőrzést is meg kéne írni, hogy minden ki legyen töltve
            vasarlo.Name = textBoxName.Text;
            vasarlo.Date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            string nem = comboBoxGender.SelectedItem.ToString();
            vasarlo.Gender =comboBoxGender.SelectedValue.ToString();
            vasarlo.Payment =(long) nuPayment.Value;
            //--a json server tudja az autoincrementet -- automatikusan adja meg az id-t
            var json = JsonConvert.SerializeObject(vasarlo); //--továbbítandó adat
            var data = new StringContent(json, Encoding.UTF8, "application/json"); //--fejléccel is elláttuk
            var respnse = client.PostAsync(endPoint, data).Result;
            if (respnse.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres hozzáadás");
                listaFrissites();
            }
            else
            {
                MessageBox.Show("Sikertelen hozzáadás");
            }
            textBoxId.Text = string.Empty;
            textBoxName.Text = string.Empty;
            nuPayment.Value = nuPayment.Minimum;
            comboBoxGender.Text = "";
            dateTimePickerDate.Checked = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //--rendelkezésre álló adatok ellenőrzése
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Nincs vásárló kiválasztva");
                return;
            }
            if(textBoxName.Text.Length < 3)
            {
                MessageBox.Show("Név megadása kötelező");
                textBoxName.Focus();
                return;
            }
            //--ha nincs dátum beállítva a datetime pickerben, mert alapból hiába van egy dárum a checkboxnal checkednek kell lenni ahoz h az a dátum elmentődjön
            if(!dateTimePickerDate.Checked)
            {
                MessageBox.Show("Kérem adjon meg dátumot!");
                return;
            }
            //meg kell nézni ugyanígy h jó e a dátum + stb. adatok is, ha mindet ellenőriztük:
            //módosítás
            Vasarlas vasarlo = new Vasarlas();
            vasarlo.Id = long.Parse(textBoxId.Text);
            vasarlo.Name = textBoxName.Text;
            vasarlo.Date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            string nem = comboBoxGender.SelectedItem.ToString();
            vasarlo.Gender = comboBoxGender.SelectedValue.ToString();
            vasarlo.Payment = (long)nuPayment.Value;
            var json = JsonConvert.SerializeObject(vasarlo); //--továbbítandó adat
            var data = new StringContent(json, Encoding.UTF8, "application/json"); //--fejléccel is elláttuk
            string endPointUpdate = $"({ endPoint}/{vasarlo.Id})";
            var respnse = client.PutAsync(endPointUpdate, data).Result;
            if (respnse.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres módosítás");
                listaFrissites();
            }
            else
            {
                MessageBox.Show("Sikertelen módosítás");
            }
            //-- beviteli mezők törlése
            textBoxId.Text = string.Empty;
            textBoxName.Text = string.Empty;
            nuPayment.Value = nuPayment.Minimum;
            comboBoxGender.Text = "";
            dateTimePickerDate.Checked = false;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Valóban törölni akarja?") == DialogResult.OK)
            {
                Vasarlas vasarlo = new Vasarlas();
                vasarlo.Id = long.Parse(textBoxId.Text);
                vasarlo.Name = textBoxName.Text;
                vasarlo.Date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
                string nem = comboBoxGender.SelectedItem.ToString();
                vasarlo.Gender = comboBoxGender.SelectedValue.ToString();
                vasarlo.Payment = (long)nuPayment.Value;
                
                var json = JsonConvert.SerializeObject(vasarlo); //--továbbítandó adat
                var data = new StringContent(json, Encoding.UTF8, "application/json"); //--fejléccel is elláttuk
                string endPointDelete = $"({endPoint}/{vasarlo.Id})";
                var respnse = client.DeleteAsync(endPointDelete).Result;
                if (respnse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés");
                    listaFrissites();
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés");
                }
                //-- beviteli mezők törlése
                textBoxId.Text = string.Empty;
                textBoxName.Text = string.Empty;
                nuPayment.Value = nuPayment.Minimum;
                comboBoxGender.Text = "";
                dateTimePickerDate.Checked = false;
            }
        }
    }
}
