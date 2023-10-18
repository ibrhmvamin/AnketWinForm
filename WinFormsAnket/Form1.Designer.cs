namespace WinFormsAnket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            surname = new Label();
            name = new Label();
            country = new Label();
            FatherName = new Label();
            phone = new Label();
            city = new Label();
            anket = new Label();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            fatherTextBox = new TextBox();
            phoneTextBox = new TextBox();
            cityTextBox = new TextBox();
            countryTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            pole = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            save = new Button();
            mailLabel = new Label();
            mailtextBox = new TextBox();
            loadButton = new Button();
            existedMail = new TextBox();
            SuspendLayout();
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            surname.Location = new Point(12, 76);
            surname.Name = "surname";
            surname.Size = new Size(78, 23);
            surname.TabIndex = 0;
            surname.Text = "Surname";
            surname.Click += label1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 111);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // country
            // 
            country.AutoSize = true;
            country.Location = new Point(12, 195);
            country.Name = "country";
            country.Size = new Size(60, 20);
            country.TabIndex = 2;
            country.Text = "Country";
            // 
            // FatherName
            // 
            FatherName.AutoSize = true;
            FatherName.Location = new Point(12, 148);
            FatherName.Name = "FatherName";
            FatherName.Size = new Size(53, 20);
            FatherName.TabIndex = 3;
            FatherName.Text = "Father ";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(12, 263);
            phone.Name = "phone";
            phone.Size = new Size(78, 20);
            phone.TabIndex = 4;
            phone.Text = "Telephone";
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new Point(12, 232);
            city.Name = "city";
            city.Size = new Size(34, 20);
            city.TabIndex = 5;
            city.Text = "City";
            // 
            // anket
            // 
            anket.AutoSize = true;
            anket.Location = new Point(12, 27);
            anket.Name = "anket";
            anket.Size = new Size(47, 20);
            anket.TabIndex = 6;
            anket.Text = "Anket";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(155, 76);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(125, 27);
            surnameTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(155, 111);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 8;
            // 
            // fatherTextBox
            // 
            fatherTextBox.Location = new Point(155, 145);
            fatherTextBox.Name = "fatherTextBox";
            fatherTextBox.Size = new Size(125, 27);
            fatherTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(155, 263);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(125, 27);
            phoneTextBox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(155, 229);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(125, 27);
            cityTextBox.TabIndex = 11;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(155, 188);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(125, 27);
            countryTextBox.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 336);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 336);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 14;
            label1.Text = "Birthday";
            // 
            // pole
            // 
            pole.AutoSize = true;
            pole.Location = new Point(22, 376);
            pole.Name = "pole";
            pole.Size = new Size(37, 20);
            pole.TabIndex = 15;
            pole.Text = "Pole";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(127, 376);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 24);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Man";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(250, 376);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 24);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Woman";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            save.Location = new Point(22, 414);
            save.Name = "save";
            save.Size = new Size(335, 29);
            save.TabIndex = 18;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(12, 302);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(38, 20);
            mailLabel.TabIndex = 19;
            mailLabel.Text = "Mail";
            // 
            // mailtextBox
            // 
            mailtextBox.Location = new Point(155, 299);
            mailtextBox.Name = "mailtextBox";
            mailtextBox.Size = new Size(125, 27);
            mailtextBox.TabIndex = 20;
            // 
            // loadButton
            // 
            loadButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            loadButton.Location = new Point(258, 22);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(99, 27);
            loadButton.TabIndex = 22;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += LoadButton_Click;
            // 
            // existedMail
            // 
            existedMail.Location = new Point(107, 22);
            existedMail.Name = "existedMail";
            existedMail.Size = new Size(104, 27);
            existedMail.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 450);
            Controls.Add(existedMail);
            Controls.Add(loadButton);
            Controls.Add(mailtextBox);
            Controls.Add(mailLabel);
            Controls.Add(save);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pole);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(phoneTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(fatherTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(anket);
            Controls.Add(city);
            Controls.Add(phone);
            Controls.Add(FatherName);
            Controls.Add(country);
            Controls.Add(name);
            Controls.Add(surname);
            Name = "Form1";
            Text = "Anket";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label surname;
        private Label name;
        private Label country;
        private Label FatherName;
        private Label phone;
        private Label city;
        private Label anket;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private TextBox fatherTextBox;
        private TextBox phoneTextBox;
        private TextBox cityTextBox;
        private TextBox countryTextBox;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label pole;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button save;
        private Label mailLabel;
        private TextBox mailtextBox;
        private Button loadButton;
        private TextBox existedMail;
    }
}