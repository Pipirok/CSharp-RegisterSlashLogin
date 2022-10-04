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
    public partial class FormSignIn : Form
    {

        private bool isPasswordVisible = false;
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void buttonToggleVisibility_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            textBoxPassword.UseSystemPasswordChar = !isPasswordVisible;
            buttonToggleVisibility.BackgroundImage = isPasswordVisible ? 
                Properties.Resources.voff : 
                Properties.Resources.von;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Account signedInAcc = AccountManager.Login(textBoxLogin.Text, textBoxPassword.Text);
            if (signedInAcc == null)
            {
                MessageBox.Show("User credentials are invalid!", "Sign in error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                return;
            }

            MessageBox.Show("You've successfully logged in! Close the window to proceed to the BMI calculator",
                "Login Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormBMI fb = new FormBMI(signedInAcc.login, signedInAcc.age, signedInAcc.weight, signedInAcc.height);
            fb.Show();
            this.Hide();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            bool isTextLegal = Regex.IsMatch(textBoxLogin.Text, @"[A-Za-z0-9-_]");

            bool isTextLongEnough = textBoxLogin.TextLength > 3 && textBoxLogin.TextLength < 21;

            if (!isTextLegal || !isTextLongEnough)
            {
                labelLoginFlavourText.Text = "Login must be 4-20 alphanumeric letters, '_' or '-'";
                buttonSignIn.Enabled = false;
            }
            else
            {
                labelLoginFlavourText.Text = "";
                buttonSignIn.Enabled = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRegisterPrompt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister fr = new FormRegister();
            this.Hide();
            fr.Show();
        }
    }
}
