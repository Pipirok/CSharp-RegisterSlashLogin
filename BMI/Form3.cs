using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class FormBMI : Form
    {
        private string login;
        private int age;
        private double weight;
        private int height;

        private double BMI;
        public FormBMI(string _login, int _age, double _weight, int _height)
        {
            login = _login;
            age = _age;
            weight = _weight;
            height = _height;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labelAge.Text = age.ToString();
            labelWeight.Text = $"{weight.ToString()} kg";
            labelHeight.Text = $"{height.ToString()} cm";
            labelLogin.Text = $"Welcome, {login}!";

            BMI = (double)((int)((weight / Math.Pow((double)height/100, 2))*100))/100;
            labelBMI.Text += BMI.ToString();

            int roughBMI = (int)BMI;
            if(roughBMI < 16)
            {
                labelBMICondition.Text = "Severely thin!";
                labelBMI.ForeColor = Color.Red;
            }
            else if (roughBMI < 19)
            {
                labelBMICondition.Text = "Moderately thin";
                labelBMI.ForeColor = Color.Orange;
            }
            else if (roughBMI < 25)
            {
                labelBMICondition.Text = "Normal";
                labelBMI.ForeColor = Color.Green;
            }
            else if (roughBMI < 30)
            {
                labelBMICondition.Text = "Overweight";
                labelBMI.ForeColor = Color.Yellow;
            }
            else
            {
                labelBMICondition.Text = "Obese!";
                labelBMI.ForeColor = Color.Red;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignIn fsi = new FormSignIn();
            fsi.Show();
            this.Close();
        }
    }
}
