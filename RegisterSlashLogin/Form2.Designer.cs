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
            this.labelRegisterFlavourText = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelLoginFlavourText = new System.Windows.Forms.Label();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Enabled = false;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(161, 452);
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
            this.labelSignInPrompt.Location = new System.Drawing.Point(145, 526);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(140, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(142, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(144, 188);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(218, 34);
            this.textBoxPassword.TabIndex = 25;
            this.textBoxPassword.UseSystemPasswordChar = true;
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(142, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Password(repeat)";
            // 
            // textBoxPasswordRepeat
            // 
            this.textBoxPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordRepeat.Location = new System.Drawing.Point(144, 276);
            this.textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            this.textBoxPasswordRepeat.Size = new System.Drawing.Size(218, 34);
            this.textBoxPasswordRepeat.TabIndex = 28;
            this.textBoxPasswordRepeat.UseSystemPasswordChar = true;
            this.textBoxPasswordRepeat.TextChanged += new System.EventHandler(this.textBoxPasswordRepeat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(150, 229);
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
            this.labelPasswordFlavourText.Location = new System.Drawing.Point(18, 230);
            this.labelPasswordFlavourText.Name = "labelPasswordFlavourText";
            this.labelPasswordFlavourText.Size = new System.Drawing.Size(0, 16);
            this.labelPasswordFlavourText.TabIndex = 31;
            // 
            // labelPasswordRepeatFlavourText
            // 
            this.labelPasswordRepeatFlavourText.AutoSize = true;
            this.labelPasswordRepeatFlavourText.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordRepeatFlavourText.Location = new System.Drawing.Point(148, 313);
            this.labelPasswordRepeatFlavourText.Name = "labelPasswordRepeatFlavourText";
            this.labelPasswordRepeatFlavourText.Size = new System.Drawing.Size(0, 16);
            this.labelPasswordRepeatFlavourText.TabIndex = 32;
            // 
            // labelRegisterFlavourText
            // 
            this.labelRegisterFlavourText.AutoSize = true;
            this.labelRegisterFlavourText.ForeColor = System.Drawing.Color.Red;
            this.labelRegisterFlavourText.Location = new System.Drawing.Point(158, 500);
            this.labelRegisterFlavourText.Name = "labelRegisterFlavourText";
            this.labelRegisterFlavourText.Size = new System.Drawing.Size(0, 16);
            this.labelRegisterFlavourText.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(158, 487);
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
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaptcha.Location = new System.Drawing.Point(144, 400);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(218, 34);
            this.textBoxCaptcha.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Captcha: ";
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaptcha.Location = new System.Drawing.Point(212, 345);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(0, 46);
            this.labelCaptcha.TabIndex = 42;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(102, 358);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 36);
            this.buttonRefresh.TabIndex = 43;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(506, 557);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelCaptcha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.labelLoginFlavourText);
            this.Controls.Add(this.labelRegisterFlavourText);
            this.Controls.Add(this.label10);
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
        private System.Windows.Forms.Label labelRegisterFlavourText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelLoginFlavourText;
        private System.Windows.Forms.TextBox textBoxCaptcha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCaptcha;
        private System.Windows.Forms.Button buttonRefresh;
    }
}