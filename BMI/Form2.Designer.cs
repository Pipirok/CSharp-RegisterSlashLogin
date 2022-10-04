namespace BMI
{
    partial class FormRegister
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelSignInPrompt = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPasswordRepeat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPasswordFlavourText = new System.Windows.Forms.Label();
            this.labelPasswordRepeatFlavourText = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRegisterFlavourText = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelLoginFlavourText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(163, 408);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(179, 36);
            this.buttonRegister.TabIndex = 19;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelSignInPrompt
            // 
            this.labelSignInPrompt.AutoSize = true;
            this.labelSignInPrompt.Location = new System.Drawing.Point(147, 482);
            this.labelSignInPrompt.Name = "labelSignInPrompt";
            this.labelSignInPrompt.Size = new System.Drawing.Size(205, 16);
            this.labelSignInPrompt.TabIndex = 18;
            this.labelSignInPrompt.TabStop = true;
            this.labelSignInPrompt.Text = "Already have an account? Sign in";
            this.labelSignInPrompt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelSignInPrompt_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(144, 256);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(218, 34);
            this.textBoxPassword.TabIndex = 25;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Password(repeat)";
            // 
            // textBoxPasswordRepeat
            // 
            this.textBoxPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordRepeat.Location = new System.Drawing.Point(144, 344);
            this.textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            this.textBoxPasswordRepeat.Size = new System.Drawing.Size(218, 34);
            this.textBoxPasswordRepeat.TabIndex = 28;
            this.textBoxPasswordRepeat.TextChanged += new System.EventHandler(this.textBoxPasswordRepeat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(147, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 27;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(144, 106);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(218, 34);
            this.textBoxLogin.TabIndex = 13;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelPasswordFlavourText
            // 
            this.labelPasswordFlavourText.AutoSize = true;
            this.labelPasswordFlavourText.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordFlavourText.Location = new System.Drawing.Point(18, 292);
            this.labelPasswordFlavourText.Name = "labelPasswordFlavourText";
            this.labelPasswordFlavourText.Size = new System.Drawing.Size(0, 16);
            this.labelPasswordFlavourText.TabIndex = 31;
            // 
            // labelPasswordRepeatFlavourText
            // 
            this.labelPasswordRepeatFlavourText.AutoSize = true;
            this.labelPasswordRepeatFlavourText.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordRepeatFlavourText.Location = new System.Drawing.Point(144, 381);
            this.labelPasswordRepeatFlavourText.Name = "labelPasswordRepeatFlavourText";
            this.labelPasswordRepeatFlavourText.Size = new System.Drawing.Size(0, 16);
            this.labelPasswordRepeatFlavourText.TabIndex = 32;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(144, 184);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(50, 34);
            this.textBoxAge.TabIndex = 33;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.Location = new System.Drawing.Point(220, 184);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(50, 34);
            this.textBoxWeight.TabIndex = 34;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(216, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 36;
            this.label8.Text = "Weight";
            // 
            // labelRegisterFlavourText
            // 
            this.labelRegisterFlavourText.AutoSize = true;
            this.labelRegisterFlavourText.ForeColor = System.Drawing.Color.Red;
            this.labelRegisterFlavourText.Location = new System.Drawing.Point(160, 456);
            this.labelRegisterFlavourText.Name = "labelRegisterFlavourText";
            this.labelRegisterFlavourText.Size = new System.Drawing.Size(0, 16);
            this.labelRegisterFlavourText.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(160, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 37;
            // 
            // labelLoginFlavourText
            // 
            this.labelLoginFlavourText.AutoSize = true;
            this.labelLoginFlavourText.ForeColor = System.Drawing.Color.Red;
            this.labelLoginFlavourText.Location = new System.Drawing.Point(144, 140);
            this.labelLoginFlavourText.Name = "labelLoginFlavourText";
            this.labelLoginFlavourText.Size = new System.Drawing.Size(0, 16);
            this.labelLoginFlavourText.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "Height";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(302, 184);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(50, 34);
            this.textBoxHeight.TabIndex = 40;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 525);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelLoginFlavourText);
            this.Controls.Add(this.labelRegisterFlavourText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelPasswordRepeatFlavourText);
            this.Controls.Add(this.labelPasswordFlavourText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPasswordRepeat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelSignInPrompt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.LinkLabel labelSignInPrompt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPasswordRepeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPasswordFlavourText;
        private System.Windows.Forms.Label labelPasswordRepeatFlavourText;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRegisterFlavourText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelLoginFlavourText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxHeight;
    }
}