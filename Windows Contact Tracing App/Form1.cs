using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Contact_Tracing_App
{
    public partial class F1WindowsContactTracingApp : Form
    {
        public F1WindowsContactTracingApp()
        {
            InitializeComponent();
        }

        private void F1WindowsContactTracingApp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TextBoxFN;
        }

        private void F1WindowsContactTracingApp_Click(object sender, EventArgs e)
        {
            this.ActiveControl = TextBoxFN;
        }

        string[] datainput = new string[8];

        string gender = "";
        string Q1Ans = "";
        string Q2Ans = "";
        string Q3Ans = "";
        string Q4Ans = "";
        string Q5Ans = "";
        string Q6Ans = "";
        string Q7Ans = "";
        string Q8Ans = "";
        string placeholder = "(Required to Fill up)";

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            datainput[0] = TextBoxFN.Text;
            datainput[1] = TextBoxMN.Text;
            datainput[2] = TextBoxLN.Text;
            datainput[3] = TextBoxAge.Text;
            datainput[4] = TextBoxHomeAddress.Text;
            datainput[5] = TextBoxPhoneNumber.Text;
            datainput[6] = TextBoxTemp.Text;

            if (!datainput.Contains(placeholder))
            {
                GetGender(RdoBtnMale);
                GetGender(RdoBtnFemale);

                GetQ1Ans(RdoBtnQ1Yes);
                GetQ1Ans(RdoBtnQ1No);

                GetQ2Ans(RdoBtnQ2Yes);
                GetQ2Ans(RdoBtnQ2No);

                GetQ3Ans(RdoBtnQ3Yes);
                GetQ3Ans(RdoBtnQ3No);

                GetQ4Ans(RdoBtnQ4Yes);
                GetQ4Ans(RdoBtnQ4No);

                GetQ5Ans(RdoBtnQ5Yes);
                GetQ5Ans(RdoBtnQ5No);

                GetQ6Ans(RdoBtnQ6Yes);
                GetQ6Ans(RdoBtnQ6No);

                GetQ7Ans(RdoBtnQ7Yes);
                GetQ7Ans(RdoBtnQ7No);

                GetQ8Ans(RdoBtnQ8Yes);
                GetQ8Ans(RdoBtnQ8No);


                StreamWriter dataTxt;
                dataTxt = File.CreateText(@"C:\Users\Senon\Documents\Repositories\Windows Contact Tracing App\Windows Contact Tracing App\Properties\Records\"
                                            + datainput[2] + "," + datainput[0] + " " + datainput[1] + ".txt");

                dataTxt.WriteLine("First name: " + datainput[0] + "\n" +
                                  "Middle name: " + datainput[1] + "\n" +
                                  "Last name: " + datainput[2] + "\n" +
                                  "Age: " + datainput[3] + "\n" +
                                  "Phone number: " + datainput[4] + "\n" +
                                  "Address: " + datainput[5] + "\n" +
                                  "Gender: " + gender + "\n\n" +
                                  "User's Data Answers :" + "\n\n" +

                                  //questions
                                  "1. Have you been recently tested for COVID-19?\n" +
                                  Q1Ans + "\n" +
                                  "2. Do you have any travel history?\n" +
                                  Q2Ans + "\n" +
                                  "3. Did you come in close contact with a probable suspected person for COVID-19?\n" +
                                  Q3Ans + "\n" +
                                  "4. Fever (>38°)\n" +
                                  Q4Ans + "\n" +
                                  "5. Body Aches\n" +
                                  Q5Ans + "\n" +
                                  "6. Loss of Smell\n" +
                                  Q6Ans + "\n" +
                                  "7. Loss of Taste\n" +
                                  Q7Ans + "\n" +
                                  "8. Sore Throat\n" +
                                  Q8Ans + "\n"
                                  );
                dataTxt.Close();

                MessageBox.Show("Information Submitted Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetAllControls(this);

            }
            else
            {
                MessageBox.Show("Please fill out all required fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private string GetGender(RadioButton radioButton)
        {
            if (radioButton.Checked)
            {
                gender = radioButton.Text;
            }
            return gender;
        }

        private string GetQ1Ans(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                Q1Ans = radiobutton.Text;
            }
            return Q1Ans;
        }

        private string GetQ2Ans(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                Q2Ans = radiobutton.Text;
            }
            return Q2Ans;
        }

        private string GetQ3Ans(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                Q3Ans = radiobutton.Text;
            }
            return Q3Ans;
        }

        private string GetQ4Ans(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                Q4Ans = radiobutton.Text;
            }
            return Q4Ans;
        }

        private string GetQ5Ans(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                Q5Ans = radiobutton.Text;
            }
            return Q5Ans;
        }

        private string GetQ6Ans(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                Q6Ans = radiobutton.Text;
            }
            return Q6Ans;
        }

        private string GetQ7Ans(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                Q7Ans = radiobutton.Text;
            }
            return Q7Ans;
        }

        private string GetQ8Ans(RadioButton radiobutton)
        {
            if (radiobutton.Checked)
            {
                Q8Ans = radiobutton.Text;
            }
            return Q8Ans;
        }





        private void WCTIcon_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RdoBtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequiredField_Enter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == placeholder)
            {
                textbox.Text = "";
            }
            textbox.ForeColor = Color.Black;
        }


        private void TxtBoxNum_Keypress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void RequiredField_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == "")
            {
                textbox.Text = placeholder;
                textbox.ForeColor = Color.DarkGray;
            }
        }

        private void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.DarkGray;
                }

                /*if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.
                }*/

                RdoBtnMale.Checked = false;
                RdoBtnFemale.Checked = false;
                

                RdoBtnQ1Yes.Checked = false;
                RdoBtnQ1No.Checked = false;

                RdoBtnQ2Yes.Checked = false;
                RdoBtnQ2No.Checked = false;

                RdoBtnQ3Yes.Checked = false;
                RdoBtnQ3No.Checked = false;

                RdoBtnQ4Yes.Checked = false;
                RdoBtnQ4No.Checked = false;

                RdoBtnQ5Yes.Checked = false;
                RdoBtnQ5No.Checked = false;

                RdoBtnQ6Yes.Checked = false;
                RdoBtnQ6No.Checked = false;

                RdoBtnQ7Yes.Checked = false;
                RdoBtnQ7No.Checked = false;

                RdoBtnQ8Yes.Checked = false;
                RdoBtnQ8No.Checked = false;


                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
        }

        private void TextBoxHomeAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxTemp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
