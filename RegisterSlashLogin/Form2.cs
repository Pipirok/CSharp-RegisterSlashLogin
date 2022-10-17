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

        private Random random = new Random();
        private string captcha = "";

        internal void UpdateCaptcha()
        {
            string captcha = "";
            for (int i = 0; i < random.Next(6, 10); i++)
            {
                if (random.Next(2) % 2 == 0)
                {
                    captcha += char.ConvertFromUtf32(random.Next(65, 91));
                    continue;
                }
                captcha += random.Next(0, 10).ToString();
            }
            this.captcha = captcha;
            labelCaptcha.Text = captcha;
        }

        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            UpdateCaptcha();
        }

        private void evaluateButtonEnable()
        {
            buttonRegister.Enabled = isLoginLegal &&
                isPasswordLegal &&
                doPasswordsMatch;
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


        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            bool hasPasswordUppercase = Regex.IsMatch(textBoxPassword.Text, @"[A-Z]");
            bool hasPasswordNumber = Regex.IsMatch(textBoxPassword.Text, @"[0-9]");
            bool hasSpecialCharacter = Regex.IsMatch(textBoxPassword.Text, @"[^0-9A-Za-z]");
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
            if (textBoxCaptcha.Text == captcha)
            {
                AccountManager.Register(textBoxLogin.Text, textBoxPassword.Text);
                MessageBox.Show("Account created successfully!",
                "Register success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Captcha is incorrect! Try again", "Captcha failure!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            UpdateCaptcha();
            textBoxCaptcha.Text = "";
            textBoxCaptcha.Focus();
            
        }

        private void labelSignInPrompt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignIn fsi = new FormSignIn();
            this.Hide();
            fsi.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateCaptcha();
            textBoxCaptcha.Text = "";
            textBoxCaptcha.Focus();
        }
    }
}
