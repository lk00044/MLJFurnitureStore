namespace cs6232_g4.UserControls
{
    partial class MemberRegistrationUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            memberRegistrationLabel = new Label();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            phoneLabel = new Label();
            address1Label = new Label();
            address2Label = new Label();
            cityLabel = new Label();
            stateLabel = new Label();
            zipLabel = new Label();
            genderLabel = new Label();
            dobLabel = new Label();
            registerButton = new Button();
            cancelButton = new Button();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            address1TextBox = new TextBox();
            address2TextBox = new TextBox();
            cityTextBox = new TextBox();
            zipTextBox = new TextBox();
            monthComboBox = new ComboBox();
            dayComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            genderComboBox = new ComboBox();
            stateComboBox = new ComboBox();
            SuspendLayout();
            // 
            // memberRegistrationLabel
            // 
            memberRegistrationLabel.AutoSize = true;
            memberRegistrationLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            memberRegistrationLabel.Location = new Point(94, 17);
            memberRegistrationLabel.Name = "memberRegistrationLabel";
            memberRegistrationLabel.Size = new Size(271, 30);
            memberRegistrationLabel.TabIndex = 0;
            memberRegistrationLabel.Text = "StoreMember Registration";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(17, 68);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(92, 21);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(17, 118);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(90, 21);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(17, 165);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(59, 21);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Phone";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address1Label.Location = new Point(17, 212);
            address1Label.Name = "address1Label";
            address1Label.Size = new Size(70, 21);
            address1Label.TabIndex = 4;
            address1Label.Text = "Address";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address2Label.Location = new Point(17, 257);
            address2Label.Name = "address2Label";
            address2Label.Size = new Size(86, 21);
            address2Label.TabIndex = 5;
            address2Label.Text = "Apt/Unit#";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cityLabel.Location = new Point(17, 309);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(40, 21);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stateLabel.Location = new Point(17, 364);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(49, 21);
            stateLabel.TabIndex = 7;
            stateLabel.Text = "State";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zipLabel.Location = new Point(17, 423);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new Size(72, 21);
            zipLabel.TabIndex = 8;
            zipLabel.Text = "Zipcode";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderLabel.Location = new Point(17, 476);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(65, 21);
            genderLabel.TabIndex = 9;
            genderLabel.Text = "Gender";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(17, 530);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(107, 21);
            dobLabel.TabIndex = 10;
            dobLabel.Text = "Date of Birth";
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.Location = new Point(94, 582);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(95, 36);
            registerButton.TabIndex = 11;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += RegisterButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(239, 582);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(87, 36);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(148, 68);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(202, 29);
            firstNameTextBox.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(148, 118);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(202, 29);
            lastNameTextBox.TabIndex = 15;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneTextBox.Location = new Point(148, 165);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(202, 29);
            phoneTextBox.TabIndex = 16;
            // 
            // address1TextBox
            // 
            address1TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address1TextBox.Location = new Point(148, 209);
            address1TextBox.Name = "address1TextBox";
            address1TextBox.Size = new Size(202, 29);
            address1TextBox.TabIndex = 17;
            // 
            // address2TextBox
            // 
            address2TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address2TextBox.Location = new Point(148, 257);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(202, 29);
            address2TextBox.TabIndex = 18;
            // 
            // cityTextBox
            // 
            cityTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cityTextBox.Location = new Point(148, 309);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(202, 29);
            cityTextBox.TabIndex = 19;
            // 
            // zipTextBox
            // 
            zipTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zipTextBox.Location = new Point(148, 423);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(202, 29);
            zipTextBox.TabIndex = 21;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            monthComboBox.Location = new Point(148, 528);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(52, 23);
            monthComboBox.TabIndex = 23;
            // 
            // dayComboBox
            // 
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayComboBox.Location = new Point(206, 528);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(52, 23);
            dayComboBox.TabIndex = 24;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Items.AddRange(new object[] { "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            yearComboBox.Location = new Point(264, 528);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(86, 23);
            yearComboBox.TabIndex = 25;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderComboBox.Location = new Point(148, 478);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(52, 23);
            genderComboBox.TabIndex = 26;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Items.AddRange(new object[] { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            stateComboBox.Location = new Point(148, 366);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(52, 23);
            stateComboBox.TabIndex = 27;
            // 
            // MemberRegistrationUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(stateComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(yearComboBox);
            Controls.Add(dayComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(zipTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(address2TextBox);
            Controls.Add(address1TextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(cancelButton);
            Controls.Add(registerButton);
            Controls.Add(dobLabel);
            Controls.Add(genderLabel);
            Controls.Add(zipLabel);
            Controls.Add(stateLabel);
            Controls.Add(cityLabel);
            Controls.Add(address2Label);
            Controls.Add(address1Label);
            Controls.Add(phoneLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(memberRegistrationLabel);
            Name = "MemberRegistrationUserControl";
            Size = new Size(415, 650);
            Load += MemberRegistrationUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label memberRegistrationLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label phoneLabel;
        private Label address1Label;
        private Label address2Label;
        private Label cityLabel;
        private Label stateLabel;
        private Label zipLabel;
        private Label genderLabel;
        private Label dobLabel;
        private Button registerButton;
        private Button cancelButton;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox phoneTextBox;
        private TextBox address1TextBox;
        private TextBox address2TextBox;
        private TextBox cityTextBox;
        private TextBox zipTextBox;
        private ComboBox monthComboBox;
        private ComboBox dayComboBox;
        private ComboBox yearComboBox;
        private ComboBox genderComboBox;
        private ComboBox stateComboBox;
    }
}
