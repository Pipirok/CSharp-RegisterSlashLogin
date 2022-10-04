using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class FormRegister : Form
    {
        private bool isLoginLegal = false;
        private bool isPasswordLegal = false;
        private bool doPasswordsMatch = false;
        private bool isAgeLegal = false;
        private bool isWeightLegal = false;
        private bool isHeightLegal = false;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void evaluateButtonEnable()
        {
            buttonRegister.Enabled = isLoginLegal && 
                isPasswordLegal && 
                doPasswordsMatch && 
                isAgeLegal && 
                isHeightLegal &&
                isWeightLegal;
        }

        private void computeRegisterFlavourText()
        {
            if(isAgeLegal && isWeightLegal && isHeightLegal)
            {
                labelRegisterFlavourText.Text = "";
                return;
            }
            string flavourText = "Check ";
            if (!isAgeLegal) flavourText += " age";
            if (!isWeightLegal) flavourText += " weight";
            if (!isHeightLegal) flavourText += " height";
            flavourText += "!";
            labelRegisterFlavourText.Text = flavourText;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            bool isTextLegal = Regex.IsMatch(textBoxLogin.Text, @"[A-Za-z0-9-_]");

            bool isTextLongEnough = textBoxLogin.TextLength > 3 && textBoxLogin.TextLength < 21;

            if (!isTextLegal || !isTextLongEnough)
            {
                labelLoginFlavourText.Text = "Login must be 4-20 alphanumeric letters, '_' or '-'";
                isLoginLegal = false;
            }
            else if(AccountManager.DoesAccountExist(textBoxLogin.Text))
            {
                labelLoginFlavourText.Text = "Login already taken!";
                isLoginLegal = false;
            }
            else
            {
                labelLoginFlavourText.Text = "";
                isLoginLegal = true;
            }

            evaluateButtonEnable();
        }

        private void maskedTextBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            bool hasPasswordUppercase = Regex.IsMatch(textBoxPassword.Text, @"[A-Z]");
            bool hasPasswordNumber = Regex.IsMatch(textBoxPassword.Text, @"[0-9]");
            bool hasSpecialCharacter = Regex.IsMatch(textBoxPassword.Text, @"^[\\s\\dA-Za-z]");
            bool isPasswordLegalLength = textBoxPassword.TextLength > 6 && textBoxPassword.TextLength < 64;

            if(!hasPasswordNumber || !hasSpecialCharacter || !isPasswordLegalLength || !hasPasswordUppercase)
            {
                labelPasswordFlavourText.Text = "Password must be 7-63 characters, \nand must contain at least 1 number, capital letter and a special symbol.";
                isPasswordLegal = false;
            }
            else
            {
                labelPasswordFlavourText.Text = "";
                isPasswordLegal = true;
            }

            if (textBoxPassword.Text == textBoxPasswordRepeat.Text)
            {
                doPasswordsMatch = true;
                labelPasswordRepeatFlavourText.Text = "";
            }
            else
            {
                doPasswordsMatch = false;
                labelPasswordRepeatFlavourText.Text = "Passwords do not match!";
            }
            evaluateButtonEnable();
        }

        private void textBoxPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == textBoxPasswordRepeat.Text)
            {
                doPasswordsMatch = true;
                labelPasswordRepeatFlavourText.Text = "";
            }
            else
            {
                doPasswordsMatch = false;
                labelPasswordRepeatFlavourText.Text = "Passwords do not match!";
            }

            evaluateButtonEnable();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Account registeredAcc = AccountManager.Register(textBoxLogin.Text, textBoxPassword.Text,
                int.Parse(textBoxAge.Text), double.Parse(textBoxWeight.Text),
                int.Parse(textBoxHeight.Text));
            MessageBox.Show("Account created successfully! Close this window to proceed to the BMI calculator.",
                "Register success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormBMI fb = new FormBMI(registeredAcc.login, registeredAcc.age, registeredAcc.weight, registeredAcc.height);
            fb.Show();
            this.Hide();
        }

        private void labelSignInPrompt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignIn fsi = new FormSignIn();
            this.Hide();
            fsi.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAge.Text, out int parsedAge))
            {
                isAgeLegal = true;
                return;
            }
            else
            {
                isAgeLegal = false;
            }

            evaluateButtonEnable();
            computeRegisterFlavourText();
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
            double.Parse(textBoxWeight.Text);
                isWeightLegal = true;
                return;
            }
            catch
            {
                isWeightLegal = false;
            }
            finally
            {
            evaluateButtonEnable();
            computeRegisterFlavourText();
            }
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                int.Parse(textBoxHeight.Text);
                isHeightLegal = true;
            }
            catch
            {
                isHeightLegal = false;
            }
            finally
            {
            evaluateButtonEnable();
            computeRegisterFlavourText();
            }
        }
    }
}
