namespace Windows_Contact_Tracing_App
{
    partial class F1WindowsContactTracingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F1WindowsContactTracingApp));
            this.TitleHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WCTIcon = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.TextBoxFN = new System.Windows.Forms.TextBox();
            this.TextBoxMN = new System.Windows.Forms.TextBox();
            this.LabelMiddleName = new System.Windows.Forms.Label();
            this.TextBoxLN = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.DataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TextBoxTemp = new System.Windows.Forms.TextBox();
            this.LabelTemp = new System.Windows.Forms.Label();
            this.LabelDandT = new System.Windows.Forms.Label();
            this.TextBoxAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxHomeAddress = new System.Windows.Forms.TextBox();
            this.LabelHomeAddress = new System.Windows.Forms.Label();
            this.LabelGender = new System.Windows.Forms.Label();
            this.RdoBtnMale = new System.Windows.Forms.RadioButton();
            this.RdoBtnFemale = new System.Windows.Forms.RadioButton();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.LabelInstruction = new System.Windows.Forms.Label();
            this.LabelInThePast14Days = new System.Windows.Forms.Label();
            this.Q1 = new System.Windows.Forms.Label();
            this.RdoBtnQ1No = new System.Windows.Forms.RadioButton();
            this.RdoBtnQ1Yes = new System.Windows.Forms.RadioButton();
            this.Q3 = new System.Windows.Forms.Label();
            this.Q2 = new System.Windows.Forms.Label();
            this.LabelHYEFollowingSymptoms = new System.Windows.Forms.Label();
            this.Q4 = new System.Windows.Forms.Label();
            this.Q5 = new System.Windows.Forms.Label();
            this.Q6 = new System.Windows.Forms.Label();
            this.Q7 = new System.Windows.Forms.Label();
            this.Q8 = new System.Windows.Forms.Label();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.GrpBoxQ1 = new System.Windows.Forms.GroupBox();
            this.GrpBoxQ2 = new System.Windows.Forms.GroupBox();
            this.RdoBtnQ2Yes = new System.Windows.Forms.RadioButton();
            this.RdoBtnQ2No = new System.Windows.Forms.RadioButton();
            this.GrpBoxQ3 = new System.Windows.Forms.GroupBox();
            this.RdoBtnQ3Yes = new System.Windows.Forms.RadioButton();
            this.RdoBtnQ3No = new System.Windows.Forms.RadioButton();
            this.GrpBoxQ4 = new System.Windows.Forms.GroupBox();
            this.RdoBtnQ4Yes = new System.Windows.Forms.RadioButton();
            this.RdoBtnQ4No = new System.Windows.Forms.RadioButton();
            this.GrpBoxQ5 = new System.Windows.Forms.GroupBox();
            this.RdoBtnQ5Yes = new System.Windows.Forms.RadioButton();
            this.RdoBtnQ5No = new System.Windows.Forms.RadioButton();
            this.GrpBoxQ6 = new System.Windows.Forms.GroupBox();
            this.RdoBtnQ6Yes = new System.Windows.Forms.RadioButton();
            this.RdoBtnQ6No = new System.Windows.Forms.RadioButton();
            this.GrpBoxQ7 = new System.Windows.Forms.GroupBox();
            this.RdoBtnQ7Yes = new System.Windows.Forms.RadioButton();
            this.RdoBtnQ7No = new System.Windows.Forms.RadioButton();
            this.GrpBoxQ8 = new System.Windows.Forms.GroupBox();
            this.RdoBtnQ8Yes = new System.Windows.Forms.RadioButton();
            this.RdoBtnQ8No = new System.Windows.Forms.RadioButton();
            this.TitleHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WCTIcon)).BeginInit();
            this.GrpBoxQ1.SuspendLayout();
            this.GrpBoxQ2.SuspendLayout();
            this.GrpBoxQ3.SuspendLayout();
            this.GrpBoxQ4.SuspendLayout();
            this.GrpBoxQ5.SuspendLayout();
            this.GrpBoxQ6.SuspendLayout();
            this.GrpBoxQ7.SuspendLayout();
            this.GrpBoxQ8.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleHeader
            // 
            this.TitleHeader.BackColor = System.Drawing.Color.PaleGreen;
            this.TitleHeader.Controls.Add(this.label1);
            this.TitleHeader.Controls.Add(this.WCTIcon);
            this.TitleHeader.Controls.Add(this.Title);
            this.TitleHeader.Location = new System.Drawing.Point(12, 12);
            this.TitleHeader.Name = "TitleHeader";
            this.TitleHeader.Size = new System.Drawing.Size(630, 100);
            this.TitleHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Please Fill-Up The Form Correctly*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WCTIcon
            // 
            this.WCTIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WCTIcon.Image = global::Windows_Contact_Tracing_App.Properties.Resources.unnamed;
            this.WCTIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("WCTIcon.InitialImage")));
            this.WCTIcon.Location = new System.Drawing.Point(495, 3);
            this.WCTIcon.Name = "WCTIcon";
            this.WCTIcon.Size = new System.Drawing.Size(132, 97);
            this.WCTIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WCTIcon.TabIndex = 1;
            this.WCTIcon.TabStop = false;
            this.WCTIcon.Click += new System.EventHandler(this.WCTIcon_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(58, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(416, 44);
            this.Title.TabIndex = 0;
            this.Title.Text = "Contact Tracing Form";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.LabelFirstName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.Location = new System.Drawing.Point(42, 175);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(105, 20);
            this.LabelFirstName.TabIndex = 1;
            this.LabelFirstName.Text = "First Name:";
            // 
            // TextBoxFN
            // 
            this.TextBoxFN.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxFN.Location = new System.Drawing.Point(46, 198);
            this.TextBoxFN.Name = "TextBoxFN";
            this.TextBoxFN.Size = new System.Drawing.Size(174, 20);
            this.TextBoxFN.TabIndex = 1;
            this.TextBoxFN.Text = "(Required field)";
            this.TextBoxFN.TextChanged += new System.EventHandler(this.TextBoxFN_TextChanged);
            this.TextBoxFN.Enter += new System.EventHandler(this.RequiredField_Enter);
            this.TextBoxFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxChar_KeyPress);
            this.TextBoxFN.Leave += new System.EventHandler(this.RequiredField_Leave);
            // 
            // TextBoxMN
            // 
            this.TextBoxMN.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxMN.Location = new System.Drawing.Point(252, 199);
            this.TextBoxMN.Name = "TextBoxMN";
            this.TextBoxMN.Size = new System.Drawing.Size(174, 20);
            this.TextBoxMN.TabIndex = 2;
            this.TextBoxMN.Text = "(Required field)";
            this.TextBoxMN.Enter += new System.EventHandler(this.RequiredField_Enter);
            this.TextBoxMN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxChar_KeyPress);
            this.TextBoxMN.Leave += new System.EventHandler(this.RequiredField_Leave);
            // 
            // LabelMiddleName
            // 
            this.LabelMiddleName.AutoSize = true;
            this.LabelMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.LabelMiddleName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMiddleName.Location = new System.Drawing.Point(251, 175);
            this.LabelMiddleName.Name = "LabelMiddleName";
            this.LabelMiddleName.Size = new System.Drawing.Size(122, 20);
            this.LabelMiddleName.TabIndex = 3;
            this.LabelMiddleName.Text = "Middle Name:";
            // 
            // TextBoxLN
            // 
            this.TextBoxLN.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxLN.Location = new System.Drawing.Point(445, 199);
            this.TextBoxLN.Name = "TextBoxLN";
            this.TextBoxLN.Size = new System.Drawing.Size(174, 20);
            this.TextBoxLN.TabIndex = 3;
            this.TextBoxLN.Text = "(Required field)";
            this.TextBoxLN.Enter += new System.EventHandler(this.RequiredField_Enter);
            this.TextBoxLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxChar_KeyPress);
            this.TextBoxLN.Leave += new System.EventHandler(this.RequiredField_Leave);
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.BackColor = System.Drawing.Color.Transparent;
            this.LabelLastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.Location = new System.Drawing.Point(451, 175);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(104, 20);
            this.LabelLastName.TabIndex = 5;
            this.LabelLastName.Text = "Last Name:";
            // 
            // DataTimePicker
            // 
            this.DataTimePicker.Location = new System.Drawing.Point(301, 135);
            this.DataTimePicker.Name = "DataTimePicker";
            this.DataTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DataTimePicker.TabIndex = 0;
            // 
            // TextBoxTemp
            // 
            this.TextBoxTemp.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxTemp.Location = new System.Drawing.Point(459, 298);
            this.TextBoxTemp.Name = "TextBoxTemp";
            this.TextBoxTemp.Size = new System.Drawing.Size(82, 20);
            this.TextBoxTemp.TabIndex = 7;
            this.TextBoxTemp.Text = "(Required field)";
            this.TextBoxTemp.TextChanged += new System.EventHandler(this.TextBoxTemp_TextChanged);
            this.TextBoxTemp.Enter += new System.EventHandler(this.RequiredField_Enter);
            this.TextBoxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxNum_Keypress);
            this.TextBoxTemp.Leave += new System.EventHandler(this.RequiredField_Leave);
            // 
            // LabelTemp
            // 
            this.LabelTemp.AutoSize = true;
            this.LabelTemp.BackColor = System.Drawing.Color.Transparent;
            this.LabelTemp.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTemp.Location = new System.Drawing.Point(333, 296);
            this.LabelTemp.Name = "LabelTemp";
            this.LabelTemp.Size = new System.Drawing.Size(120, 20);
            this.LabelTemp.TabIndex = 8;
            this.LabelTemp.Text = "Temperature:";
            // 
            // LabelDandT
            // 
            this.LabelDandT.AutoSize = true;
            this.LabelDandT.BackColor = System.Drawing.Color.Transparent;
            this.LabelDandT.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDandT.Location = new System.Drawing.Point(154, 135);
            this.LabelDandT.Name = "LabelDandT";
            this.LabelDandT.Size = new System.Drawing.Size(137, 20);
            this.LabelDandT.TabIndex = 10;
            this.LabelDandT.Text = "Date and Time:";
            // 
            // TextBoxAge
            // 
            this.TextBoxAge.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxAge.Location = new System.Drawing.Point(198, 254);
            this.TextBoxAge.Name = "TextBoxAge";
            this.TextBoxAge.Size = new System.Drawing.Size(52, 20);
            this.TextBoxAge.TabIndex = 4;
            this.TextBoxAge.Text = "(Required field)";
            this.TextBoxAge.Enter += new System.EventHandler(this.RequiredField_Enter);
            this.TextBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxNum_Keypress);
            this.TextBoxAge.Leave += new System.EventHandler(this.RequiredField_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age:";
            // 
            // TextBoxHomeAddress
            // 
            this.TextBoxHomeAddress.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxHomeAddress.Location = new System.Drawing.Point(276, 254);
            this.TextBoxHomeAddress.Name = "TextBoxHomeAddress";
            this.TextBoxHomeAddress.Size = new System.Drawing.Size(343, 20);
            this.TextBoxHomeAddress.TabIndex = 5;
            this.TextBoxHomeAddress.Text = "(Required field)";
            this.TextBoxHomeAddress.TextChanged += new System.EventHandler(this.TextBoxHomeAddress_TextChanged);
            this.TextBoxHomeAddress.Enter += new System.EventHandler(this.RequiredField_Enter);
            this.TextBoxHomeAddress.Leave += new System.EventHandler(this.RequiredField_Leave);
            // 
            // LabelHomeAddress
            // 
            this.LabelHomeAddress.AutoSize = true;
            this.LabelHomeAddress.BackColor = System.Drawing.Color.Transparent;
            this.LabelHomeAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHomeAddress.Location = new System.Drawing.Point(272, 231);
            this.LabelHomeAddress.Name = "LabelHomeAddress";
            this.LabelHomeAddress.Size = new System.Drawing.Size(218, 20);
            this.LabelHomeAddress.TabIndex = 13;
            this.LabelHomeAddress.Text = "Complete Home Address:";
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.BackColor = System.Drawing.Color.Transparent;
            this.LabelGender.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGender.Location = new System.Drawing.Point(73, 231);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(74, 20);
            this.LabelGender.TabIndex = 15;
            this.LabelGender.Text = "Gender:";
            // 
            // RdoBtnMale
            // 
            this.RdoBtnMale.AutoSize = true;
            this.RdoBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnMale.Location = new System.Drawing.Point(43, 254);
            this.RdoBtnMale.Name = "RdoBtnMale";
            this.RdoBtnMale.Size = new System.Drawing.Size(55, 20);
            this.RdoBtnMale.TabIndex = 8;
            this.RdoBtnMale.TabStop = true;
            this.RdoBtnMale.Text = "Male";
            this.RdoBtnMale.UseVisualStyleBackColor = true;
            this.RdoBtnMale.CheckedChanged += new System.EventHandler(this.RdoBtnMale_CheckedChanged);
            // 
            // RdoBtnFemale
            // 
            this.RdoBtnFemale.AutoSize = true;
            this.RdoBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnFemale.Location = new System.Drawing.Point(97, 254);
            this.RdoBtnFemale.Name = "RdoBtnFemale";
            this.RdoBtnFemale.Size = new System.Drawing.Size(71, 20);
            this.RdoBtnFemale.TabIndex = 9;
            this.RdoBtnFemale.TabStop = true;
            this.RdoBtnFemale.Text = "Female";
            this.RdoBtnFemale.UseVisualStyleBackColor = true;
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(183, 298);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(131, 20);
            this.TextBoxPhoneNumber.TabIndex = 6;
            this.TextBoxPhoneNumber.Text = "(Required field)";
            this.TextBoxPhoneNumber.Enter += new System.EventHandler(this.RequiredField_Enter);
            this.TextBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxNum_Keypress);
            this.TextBoxPhoneNumber.Leave += new System.EventHandler(this.RequiredField_Leave);
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhoneNumber.Location = new System.Drawing.Point(42, 296);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(135, 20);
            this.LabelPhoneNumber.TabIndex = 18;
            this.LabelPhoneNumber.Text = "Phone Number:";
            // 
            // LabelInstruction
            // 
            this.LabelInstruction.AutoSize = true;
            this.LabelInstruction.BackColor = System.Drawing.Color.Transparent;
            this.LabelInstruction.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstruction.Location = new System.Drawing.Point(126, 337);
            this.LabelInstruction.Name = "LabelInstruction";
            this.LabelInstruction.Size = new System.Drawing.Size(412, 15);
            this.LabelInstruction.TabIndex = 21;
            this.LabelInstruction.Text = "Instruction: Please Tick an Answer For Every Question Item.";
            // 
            // LabelInThePast14Days
            // 
            this.LabelInThePast14Days.AutoSize = true;
            this.LabelInThePast14Days.BackColor = System.Drawing.Color.Transparent;
            this.LabelInThePast14Days.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInThePast14Days.Location = new System.Drawing.Point(43, 363);
            this.LabelInThePast14Days.Name = "LabelInThePast14Days";
            this.LabelInThePast14Days.Size = new System.Drawing.Size(157, 16);
            this.LabelInThePast14Days.TabIndex = 22;
            this.LabelInThePast14Days.Text = "In The Past 14 Days...";
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.BackColor = System.Drawing.Color.Transparent;
            this.Q1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1.Location = new System.Drawing.Point(43, 379);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(331, 16);
            this.Q1.TabIndex = 23;
            this.Q1.Text = "1. Have you been recently tested for COVID-19?";
            // 
            // RdoBtnQ1No
            // 
            this.RdoBtnQ1No.AutoSize = true;
            this.RdoBtnQ1No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ1No.Location = new System.Drawing.Point(58, 13);
            this.RdoBtnQ1No.Name = "RdoBtnQ1No";
            this.RdoBtnQ1No.Size = new System.Drawing.Size(43, 20);
            this.RdoBtnQ1No.TabIndex = 11;
            this.RdoBtnQ1No.TabStop = true;
            this.RdoBtnQ1No.Text = "No";
            this.RdoBtnQ1No.UseVisualStyleBackColor = true;
            // 
            // RdoBtnQ1Yes
            // 
            this.RdoBtnQ1Yes.AutoSize = true;
            this.RdoBtnQ1Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ1Yes.Location = new System.Drawing.Point(6, 13);
            this.RdoBtnQ1Yes.Name = "RdoBtnQ1Yes";
            this.RdoBtnQ1Yes.Size = new System.Drawing.Size(49, 20);
            this.RdoBtnQ1Yes.TabIndex = 10;
            this.RdoBtnQ1Yes.TabStop = true;
            this.RdoBtnQ1Yes.Text = "Yes";
            this.RdoBtnQ1Yes.UseVisualStyleBackColor = true;
            // 
            // Q3
            // 
            this.Q3.AutoSize = true;
            this.Q3.BackColor = System.Drawing.Color.Transparent;
            this.Q3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q3.Location = new System.Drawing.Point(37, 447);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(478, 15);
            this.Q3.TabIndex = 26;
            this.Q3.Text = "3. Did you come in close contact with a probable suspected person for COVID-19?";
            // 
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.BackColor = System.Drawing.Color.Transparent;
            this.Q2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q2.Location = new System.Drawing.Point(40, 421);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(237, 16);
            this.Q2.TabIndex = 29;
            this.Q2.Text = "2. Do you have any travel history?";
            // 
            // LabelHYEFollowingSymptoms
            // 
            this.LabelHYEFollowingSymptoms.AutoSize = true;
            this.LabelHYEFollowingSymptoms.BackColor = System.Drawing.Color.Transparent;
            this.LabelHYEFollowingSymptoms.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHYEFollowingSymptoms.Location = new System.Drawing.Point(155, 473);
            this.LabelHYEFollowingSymptoms.Name = "LabelHYEFollowingSymptoms";
            this.LabelHYEFollowingSymptoms.Size = new System.Drawing.Size(320, 16);
            this.LabelHYEFollowingSymptoms.TabIndex = 32;
            this.LabelHYEFollowingSymptoms.Text = "Have you Experienced the following symptoms?";
            // 
            // Q4
            // 
            this.Q4.AutoSize = true;
            this.Q4.BackColor = System.Drawing.Color.Transparent;
            this.Q4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Q4.Location = new System.Drawing.Point(40, 509);
            this.Q4.Name = "Q4";
            this.Q4.Size = new System.Drawing.Size(111, 16);
            this.Q4.TabIndex = 33;
            this.Q4.Text = "4. Fever (>38°)";
            // 
            // Q5
            // 
            this.Q5.AutoSize = true;
            this.Q5.BackColor = System.Drawing.Color.Transparent;
            this.Q5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Q5.Location = new System.Drawing.Point(37, 551);
            this.Q5.Name = "Q5";
            this.Q5.Size = new System.Drawing.Size(102, 16);
            this.Q5.TabIndex = 36;
            this.Q5.Text = "5. Body Aches";
            // 
            // Q6
            // 
            this.Q6.AutoSize = true;
            this.Q6.BackColor = System.Drawing.Color.Transparent;
            this.Q6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Q6.Location = new System.Drawing.Point(36, 598);
            this.Q6.Name = "Q6";
            this.Q6.Size = new System.Drawing.Size(111, 16);
            this.Q6.TabIndex = 39;
            this.Q6.Text = "6. Loss of Smell";
            // 
            // Q7
            // 
            this.Q7.AutoSize = true;
            this.Q7.BackColor = System.Drawing.Color.Transparent;
            this.Q7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Q7.Location = new System.Drawing.Point(289, 518);
            this.Q7.Name = "Q7";
            this.Q7.Size = new System.Drawing.Size(115, 16);
            this.Q7.TabIndex = 42;
            this.Q7.Text = "7. Loss of Taste";
            // 
            // Q8
            // 
            this.Q8.AutoSize = true;
            this.Q8.BackColor = System.Drawing.Color.Transparent;
            this.Q8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Q8.Location = new System.Drawing.Point(289, 568);
            this.Q8.Name = "Q8";
            this.Q8.Size = new System.Drawing.Size(104, 16);
            this.Q8.TabIndex = 45;
            this.Q8.Text = "8. Sore Throat";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(324, 620);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(151, 71);
            this.ButtonSubmit.TabIndex = 47;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // GrpBoxQ1
            // 
            this.GrpBoxQ1.Controls.Add(this.RdoBtnQ1Yes);
            this.GrpBoxQ1.Controls.Add(this.RdoBtnQ1No);
            this.GrpBoxQ1.Location = new System.Drawing.Point(388, 363);
            this.GrpBoxQ1.Name = "GrpBoxQ1";
            this.GrpBoxQ1.Size = new System.Drawing.Size(114, 40);
            this.GrpBoxQ1.TabIndex = 48;
            this.GrpBoxQ1.TabStop = false;
            // 
            // GrpBoxQ2
            // 
            this.GrpBoxQ2.Controls.Add(this.RdoBtnQ2Yes);
            this.GrpBoxQ2.Controls.Add(this.RdoBtnQ2No);
            this.GrpBoxQ2.Location = new System.Drawing.Point(286, 404);
            this.GrpBoxQ2.Name = "GrpBoxQ2";
            this.GrpBoxQ2.Size = new System.Drawing.Size(114, 40);
            this.GrpBoxQ2.TabIndex = 49;
            this.GrpBoxQ2.TabStop = false;
            // 
            // RdoBtnQ2Yes
            // 
            this.RdoBtnQ2Yes.AutoSize = true;
            this.RdoBtnQ2Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ2Yes.Location = new System.Drawing.Point(5, 13);
            this.RdoBtnQ2Yes.Name = "RdoBtnQ2Yes";
            this.RdoBtnQ2Yes.Size = new System.Drawing.Size(49, 20);
            this.RdoBtnQ2Yes.TabIndex = 10;
            this.RdoBtnQ2Yes.TabStop = true;
            this.RdoBtnQ2Yes.Text = "Yes";
            this.RdoBtnQ2Yes.UseVisualStyleBackColor = true;
            // 
            // RdoBtnQ2No
            // 
            this.RdoBtnQ2No.AutoSize = true;
            this.RdoBtnQ2No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ2No.Location = new System.Drawing.Point(58, 13);
            this.RdoBtnQ2No.Name = "RdoBtnQ2No";
            this.RdoBtnQ2No.Size = new System.Drawing.Size(43, 20);
            this.RdoBtnQ2No.TabIndex = 11;
            this.RdoBtnQ2No.TabStop = true;
            this.RdoBtnQ2No.Text = "No";
            this.RdoBtnQ2No.UseVisualStyleBackColor = true;
            // 
            // GrpBoxQ3
            // 
            this.GrpBoxQ3.Controls.Add(this.RdoBtnQ3Yes);
            this.GrpBoxQ3.Controls.Add(this.RdoBtnQ3No);
            this.GrpBoxQ3.Location = new System.Drawing.Point(527, 432);
            this.GrpBoxQ3.Name = "GrpBoxQ3";
            this.GrpBoxQ3.Size = new System.Drawing.Size(114, 40);
            this.GrpBoxQ3.TabIndex = 50;
            this.GrpBoxQ3.TabStop = false;
            // 
            // RdoBtnQ3Yes
            // 
            this.RdoBtnQ3Yes.AutoSize = true;
            this.RdoBtnQ3Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ3Yes.Location = new System.Drawing.Point(6, 13);
            this.RdoBtnQ3Yes.Name = "RdoBtnQ3Yes";
            this.RdoBtnQ3Yes.Size = new System.Drawing.Size(49, 20);
            this.RdoBtnQ3Yes.TabIndex = 10;
            this.RdoBtnQ3Yes.TabStop = true;
            this.RdoBtnQ3Yes.Text = "Yes";
            this.RdoBtnQ3Yes.UseVisualStyleBackColor = true;
            // 
            // RdoBtnQ3No
            // 
            this.RdoBtnQ3No.AutoSize = true;
            this.RdoBtnQ3No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ3No.Location = new System.Drawing.Point(58, 13);
            this.RdoBtnQ3No.Name = "RdoBtnQ3No";
            this.RdoBtnQ3No.Size = new System.Drawing.Size(43, 20);
            this.RdoBtnQ3No.TabIndex = 11;
            this.RdoBtnQ3No.TabStop = true;
            this.RdoBtnQ3No.Text = "No";
            this.RdoBtnQ3No.UseVisualStyleBackColor = true;
            // 
            // GrpBoxQ4
            // 
            this.GrpBoxQ4.Controls.Add(this.RdoBtnQ4Yes);
            this.GrpBoxQ4.Controls.Add(this.RdoBtnQ4No);
            this.GrpBoxQ4.Location = new System.Drawing.Point(149, 492);
            this.GrpBoxQ4.Name = "GrpBoxQ4";
            this.GrpBoxQ4.Size = new System.Drawing.Size(114, 40);
            this.GrpBoxQ4.TabIndex = 51;
            this.GrpBoxQ4.TabStop = false;
            // 
            // RdoBtnQ4Yes
            // 
            this.RdoBtnQ4Yes.AutoSize = true;
            this.RdoBtnQ4Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ4Yes.Location = new System.Drawing.Point(6, 13);
            this.RdoBtnQ4Yes.Name = "RdoBtnQ4Yes";
            this.RdoBtnQ4Yes.Size = new System.Drawing.Size(49, 20);
            this.RdoBtnQ4Yes.TabIndex = 10;
            this.RdoBtnQ4Yes.TabStop = true;
            this.RdoBtnQ4Yes.Text = "Yes";
            this.RdoBtnQ4Yes.UseVisualStyleBackColor = true;
            // 
            // RdoBtnQ4No
            // 
            this.RdoBtnQ4No.AutoSize = true;
            this.RdoBtnQ4No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ4No.Location = new System.Drawing.Point(58, 13);
            this.RdoBtnQ4No.Name = "RdoBtnQ4No";
            this.RdoBtnQ4No.Size = new System.Drawing.Size(43, 20);
            this.RdoBtnQ4No.TabIndex = 11;
            this.RdoBtnQ4No.TabStop = true;
            this.RdoBtnQ4No.Text = "No";
            this.RdoBtnQ4No.UseVisualStyleBackColor = true;
            // 
            // GrpBoxQ5
            // 
            this.GrpBoxQ5.Controls.Add(this.RdoBtnQ5Yes);
            this.GrpBoxQ5.Controls.Add(this.RdoBtnQ5No);
            this.GrpBoxQ5.Location = new System.Drawing.Point(149, 538);
            this.GrpBoxQ5.Name = "GrpBoxQ5";
            this.GrpBoxQ5.Size = new System.Drawing.Size(114, 40);
            this.GrpBoxQ5.TabIndex = 51;
            this.GrpBoxQ5.TabStop = false;
            // 
            // RdoBtnQ5Yes
            // 
            this.RdoBtnQ5Yes.AutoSize = true;
            this.RdoBtnQ5Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ5Yes.Location = new System.Drawing.Point(6, 13);
            this.RdoBtnQ5Yes.Name = "RdoBtnQ5Yes";
            this.RdoBtnQ5Yes.Size = new System.Drawing.Size(49, 20);
            this.RdoBtnQ5Yes.TabIndex = 10;
            this.RdoBtnQ5Yes.TabStop = true;
            this.RdoBtnQ5Yes.Text = "Yes";
            this.RdoBtnQ5Yes.UseVisualStyleBackColor = true;
            // 
            // RdoBtnQ5No
            // 
            this.RdoBtnQ5No.AutoSize = true;
            this.RdoBtnQ5No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ5No.Location = new System.Drawing.Point(58, 13);
            this.RdoBtnQ5No.Name = "RdoBtnQ5No";
            this.RdoBtnQ5No.Size = new System.Drawing.Size(43, 20);
            this.RdoBtnQ5No.TabIndex = 11;
            this.RdoBtnQ5No.TabStop = true;
            this.RdoBtnQ5No.Text = "No";
            this.RdoBtnQ5No.UseVisualStyleBackColor = true;
            // 
            // GrpBoxQ6
            // 
            this.GrpBoxQ6.Controls.Add(this.RdoBtnQ6Yes);
            this.GrpBoxQ6.Controls.Add(this.RdoBtnQ6No);
            this.GrpBoxQ6.Location = new System.Drawing.Point(149, 585);
            this.GrpBoxQ6.Name = "GrpBoxQ6";
            this.GrpBoxQ6.Size = new System.Drawing.Size(114, 40);
            this.GrpBoxQ6.TabIndex = 52;
            this.GrpBoxQ6.TabStop = false;
            // 
            // RdoBtnQ6Yes
            // 
            this.RdoBtnQ6Yes.AutoSize = true;
            this.RdoBtnQ6Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ6Yes.Location = new System.Drawing.Point(6, 13);
            this.RdoBtnQ6Yes.Name = "RdoBtnQ6Yes";
            this.RdoBtnQ6Yes.Size = new System.Drawing.Size(49, 20);
            this.RdoBtnQ6Yes.TabIndex = 10;
            this.RdoBtnQ6Yes.TabStop = true;
            this.RdoBtnQ6Yes.Text = "Yes";
            this.RdoBtnQ6Yes.UseVisualStyleBackColor = true;
            // 
            // RdoBtnQ6No
            // 
            this.RdoBtnQ6No.AutoSize = true;
            this.RdoBtnQ6No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ6No.Location = new System.Drawing.Point(58, 13);
            this.RdoBtnQ6No.Name = "RdoBtnQ6No";
            this.RdoBtnQ6No.Size = new System.Drawing.Size(43, 20);
            this.RdoBtnQ6No.TabIndex = 11;
            this.RdoBtnQ6No.TabStop = true;
            this.RdoBtnQ6No.Text = "No";
            this.RdoBtnQ6No.UseVisualStyleBackColor = true;
            // 
            // GrpBoxQ7
            // 
            this.GrpBoxQ7.Controls.Add(this.RdoBtnQ7Yes);
            this.GrpBoxQ7.Controls.Add(this.RdoBtnQ7No);
            this.GrpBoxQ7.Location = new System.Drawing.Point(413, 505);
            this.GrpBoxQ7.Name = "GrpBoxQ7";
            this.GrpBoxQ7.Size = new System.Drawing.Size(114, 40);
            this.GrpBoxQ7.TabIndex = 53;
            this.GrpBoxQ7.TabStop = false;
            // 
            // RdoBtnQ7Yes
            // 
            this.RdoBtnQ7Yes.AutoSize = true;
            this.RdoBtnQ7Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ7Yes.Location = new System.Drawing.Point(6, 13);
            this.RdoBtnQ7Yes.Name = "RdoBtnQ7Yes";
            this.RdoBtnQ7Yes.Size = new System.Drawing.Size(49, 20);
            this.RdoBtnQ7Yes.TabIndex = 10;
            this.RdoBtnQ7Yes.TabStop = true;
            this.RdoBtnQ7Yes.Text = "Yes";
            this.RdoBtnQ7Yes.UseVisualStyleBackColor = true;
            // 
            // RdoBtnQ7No
            // 
            this.RdoBtnQ7No.AutoSize = true;
            this.RdoBtnQ7No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ7No.Location = new System.Drawing.Point(58, 13);
            this.RdoBtnQ7No.Name = "RdoBtnQ7No";
            this.RdoBtnQ7No.Size = new System.Drawing.Size(43, 20);
            this.RdoBtnQ7No.TabIndex = 11;
            this.RdoBtnQ7No.TabStop = true;
            this.RdoBtnQ7No.Text = "No";
            this.RdoBtnQ7No.UseVisualStyleBackColor = true;
            // 
            // GrpBoxQ8
            // 
            this.GrpBoxQ8.Controls.Add(this.RdoBtnQ8Yes);
            this.GrpBoxQ8.Controls.Add(this.RdoBtnQ8No);
            this.GrpBoxQ8.Location = new System.Drawing.Point(412, 551);
            this.GrpBoxQ8.Name = "GrpBoxQ8";
            this.GrpBoxQ8.Size = new System.Drawing.Size(114, 40);
            this.GrpBoxQ8.TabIndex = 54;
            this.GrpBoxQ8.TabStop = false;
            // 
            // RdoBtnQ8Yes
            // 
            this.RdoBtnQ8Yes.AutoSize = true;
            this.RdoBtnQ8Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ8Yes.Location = new System.Drawing.Point(6, 13);
            this.RdoBtnQ8Yes.Name = "RdoBtnQ8Yes";
            this.RdoBtnQ8Yes.Size = new System.Drawing.Size(49, 20);
            this.RdoBtnQ8Yes.TabIndex = 10;
            this.RdoBtnQ8Yes.TabStop = true;
            this.RdoBtnQ8Yes.Text = "Yes";
            this.RdoBtnQ8Yes.UseVisualStyleBackColor = true;
            // 
            // RdoBtnQ8No
            // 
            this.RdoBtnQ8No.AutoSize = true;
            this.RdoBtnQ8No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBtnQ8No.Location = new System.Drawing.Point(58, 13);
            this.RdoBtnQ8No.Name = "RdoBtnQ8No";
            this.RdoBtnQ8No.Size = new System.Drawing.Size(43, 20);
            this.RdoBtnQ8No.TabIndex = 11;
            this.RdoBtnQ8No.TabStop = true;
            this.RdoBtnQ8No.Text = "No";
            this.RdoBtnQ8No.UseVisualStyleBackColor = true;
            // 
            // F1WindowsContactTracingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(651, 738);
            this.Controls.Add(this.GrpBoxQ8);
            this.Controls.Add(this.GrpBoxQ7);
            this.Controls.Add(this.GrpBoxQ6);
            this.Controls.Add(this.GrpBoxQ5);
            this.Controls.Add(this.GrpBoxQ4);
            this.Controls.Add(this.GrpBoxQ3);
            this.Controls.Add(this.GrpBoxQ2);
            this.Controls.Add(this.GrpBoxQ1);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.Q8);
            this.Controls.Add(this.Q7);
            this.Controls.Add(this.Q6);
            this.Controls.Add(this.Q5);
            this.Controls.Add(this.Q4);
            this.Controls.Add(this.LabelHYEFollowingSymptoms);
            this.Controls.Add(this.Q2);
            this.Controls.Add(this.Q3);
            this.Controls.Add(this.Q1);
            this.Controls.Add(this.LabelInThePast14Days);
            this.Controls.Add(this.LabelInstruction);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.LabelPhoneNumber);
            this.Controls.Add(this.RdoBtnFemale);
            this.Controls.Add(this.RdoBtnMale);
            this.Controls.Add(this.LabelGender);
            this.Controls.Add(this.TextBoxHomeAddress);
            this.Controls.Add(this.LabelHomeAddress);
            this.Controls.Add(this.TextBoxAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelDandT);
            this.Controls.Add(this.TextBoxTemp);
            this.Controls.Add(this.LabelTemp);
            this.Controls.Add(this.DataTimePicker);
            this.Controls.Add(this.TextBoxLN);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.TextBoxMN);
            this.Controls.Add(this.LabelMiddleName);
            this.Controls.Add(this.TextBoxFN);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.TitleHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F1WindowsContactTracingApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Contact Tracing App";
            this.Load += new System.EventHandler(this.F1WindowsContactTracingApp_Load);
            this.Click += new System.EventHandler(this.F1WindowsContactTracingApp_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxChar_KeyPress);
            this.TitleHeader.ResumeLayout(false);
            this.TitleHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WCTIcon)).EndInit();
            this.GrpBoxQ1.ResumeLayout(false);
            this.GrpBoxQ1.PerformLayout();
            this.GrpBoxQ2.ResumeLayout(false);
            this.GrpBoxQ2.PerformLayout();
            this.GrpBoxQ3.ResumeLayout(false);
            this.GrpBoxQ3.PerformLayout();
            this.GrpBoxQ4.ResumeLayout(false);
            this.GrpBoxQ4.PerformLayout();
            this.GrpBoxQ5.ResumeLayout(false);
            this.GrpBoxQ5.PerformLayout();
            this.GrpBoxQ6.ResumeLayout(false);
            this.GrpBoxQ6.PerformLayout();
            this.GrpBoxQ7.ResumeLayout(false);
            this.GrpBoxQ7.PerformLayout();
            this.GrpBoxQ8.ResumeLayout(false);
            this.GrpBoxQ8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleHeader;
        private System.Windows.Forms.PictureBox WCTIcon;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.TextBox TextBoxFN;
        private System.Windows.Forms.TextBox TextBoxMN;
        private System.Windows.Forms.Label LabelMiddleName;
        private System.Windows.Forms.TextBox TextBoxLN;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.DateTimePicker DataTimePicker;
        private System.Windows.Forms.TextBox TextBoxTemp;
        private System.Windows.Forms.Label LabelTemp;
        private System.Windows.Forms.Label LabelDandT;
        private System.Windows.Forms.TextBox TextBoxAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxHomeAddress;
        private System.Windows.Forms.Label LabelHomeAddress;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.RadioButton RdoBtnMale;
        private System.Windows.Forms.RadioButton RdoBtnFemale;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.Label LabelInstruction;
        private System.Windows.Forms.Label LabelInThePast14Days;
        private System.Windows.Forms.Label Q1;
        private System.Windows.Forms.RadioButton RdoBtnQ1No;
        private System.Windows.Forms.RadioButton RdoBtnQ1Yes;
        private System.Windows.Forms.Label Q3;
        private System.Windows.Forms.Label Q2;
        private System.Windows.Forms.Label LabelHYEFollowingSymptoms;
        private System.Windows.Forms.Label Q4;
        private System.Windows.Forms.Label Q5;
        private System.Windows.Forms.Label Q6;
        private System.Windows.Forms.Label Q7;
        private System.Windows.Forms.Label Q8;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.GroupBox GrpBoxQ1;
        private System.Windows.Forms.GroupBox GrpBoxQ2;
        private System.Windows.Forms.RadioButton RdoBtnQ2Yes;
        private System.Windows.Forms.RadioButton RdoBtnQ2No;
        private System.Windows.Forms.GroupBox GrpBoxQ3;
        private System.Windows.Forms.RadioButton RdoBtnQ3Yes;
        private System.Windows.Forms.RadioButton RdoBtnQ3No;
        private System.Windows.Forms.GroupBox GrpBoxQ4;
        private System.Windows.Forms.RadioButton RdoBtnQ4Yes;
        private System.Windows.Forms.RadioButton RdoBtnQ4No;
        private System.Windows.Forms.GroupBox GrpBoxQ5;
        private System.Windows.Forms.RadioButton RdoBtnQ5Yes;
        private System.Windows.Forms.RadioButton RdoBtnQ5No;
        private System.Windows.Forms.GroupBox GrpBoxQ6;
        private System.Windows.Forms.RadioButton RdoBtnQ6Yes;
        private System.Windows.Forms.RadioButton RdoBtnQ6No;
        private System.Windows.Forms.GroupBox GrpBoxQ7;
        private System.Windows.Forms.RadioButton RdoBtnQ7Yes;
        private System.Windows.Forms.RadioButton RdoBtnQ7No;
        private System.Windows.Forms.GroupBox GrpBoxQ8;
        private System.Windows.Forms.RadioButton RdoBtnQ8Yes;
        private System.Windows.Forms.RadioButton RdoBtnQ8No;
    }
}

