namespace REST_API
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxVasarlasok = new System.Windows.Forms.ListBox();
            this.groupBoxKivalasztott = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nuPayment = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.groupBoxKivalasztott.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxVasarlasok
            // 
            this.listBoxVasarlasok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxVasarlasok.FormattingEnabled = true;
            this.listBoxVasarlasok.Location = new System.Drawing.Point(0, 0);
            this.listBoxVasarlasok.Name = "listBoxVasarlasok";
            this.listBoxVasarlasok.Size = new System.Drawing.Size(282, 450);
            this.listBoxVasarlasok.TabIndex = 0;
            this.listBoxVasarlasok.SelectedIndexChanged += new System.EventHandler(this.listBoxVasarlasok_SelectedIndexChanged);
            // 
            // groupBoxKivalasztott
            // 
            this.groupBoxKivalasztott.Controls.Add(this.buttonDelete);
            this.groupBoxKivalasztott.Controls.Add(this.buttonUpdate);
            this.groupBoxKivalasztott.Controls.Add(this.buttonRead);
            this.groupBoxKivalasztott.Controls.Add(this.buttonCreate);
            this.groupBoxKivalasztott.Controls.Add(this.dateTimePickerDate);
            this.groupBoxKivalasztott.Controls.Add(this.label4);
            this.groupBoxKivalasztott.Controls.Add(this.nuPayment);
            this.groupBoxKivalasztott.Controls.Add(this.label3);
            this.groupBoxKivalasztott.Controls.Add(this.label2);
            this.groupBoxKivalasztott.Controls.Add(this.comboBoxGender);
            this.groupBoxKivalasztott.Controls.Add(this.textBoxName);
            this.groupBoxKivalasztott.Controls.Add(this.label1);
            this.groupBoxKivalasztott.Controls.Add(this.textBoxId);
            this.groupBoxKivalasztott.Controls.Add(this.id);
            this.groupBoxKivalasztott.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxKivalasztott.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxKivalasztott.Location = new System.Drawing.Point(288, 0);
            this.groupBoxKivalasztott.Name = "groupBoxKivalasztott";
            this.groupBoxKivalasztott.Size = new System.Drawing.Size(512, 450);
            this.groupBoxKivalasztott.TabIndex = 1;
            this.groupBoxKivalasztott.TabStop = false;
            this.groupBoxKivalasztott.Text = "kiválasztott vásárlás";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(362, 315);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Töröl";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(248, 315);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Módosít";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(137, 315);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 11;
            this.buttonRead.Text = "Olvasás";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(29, 315);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Hozzáad";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Checked = false;
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(160, 244);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.ShowCheckBox = true;
            this.dateTimePickerDate.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Születési dátum";
            // 
            // nuPayment
            // 
            this.nuPayment.Location = new System.Drawing.Point(160, 188);
            this.nuPayment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nuPayment.Name = "nuPayment";
            this.nuPayment.Size = new System.Drawing.Size(112, 20);
            this.nuPayment.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Összeg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nem";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Ferfi",
            "No"});
            this.comboBoxGender.Location = new System.Drawing.Point(160, 130);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(160, 90);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(160, 41);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(88, 44);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 0;
            this.id.Text = "id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKivalasztott);
            this.Controls.Add(this.listBoxVasarlasok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxKivalasztott.ResumeLayout(false);
            this.groupBoxKivalasztott.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVasarlasok;
        private System.Windows.Forms.GroupBox groupBoxKivalasztott;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonCreate;
    }
}

