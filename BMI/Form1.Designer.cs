namespace BMI
{
    partial class FormSignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonToggleVisibility = new System.Windows.Forms.Button();
            this.labelRegisterPrompt = new System.Windows.Forms.LinkLabel();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.labelLoginFlavourText = new System.Windows.Forms.Label();
            this.labelPasswordFlavourText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "to continue to your account";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(135, 185);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(218, 34);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(135, 276);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(170, 34);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonToggleVisibility
            // 
            this.buttonToggleVisibility.BackgroundImage = global::BMI.Properties.Resources.von;
            this.buttonToggleVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonToggleVisibility.Location = new System.Drawing.Point(311, 277);
            this.buttonToggleVisibility.Name = "buttonToggleVisibility";
            this.buttonToggleVisibility.Size = new System.Drawing.Size(42, 33);
            this.buttonToggleVisibility.TabIndex = 6;
            this.buttonToggleVisibility.UseVisualStyleBackColor = true;
            this.buttonToggleVisibility.Click += new System.EventHandler(this.buttonToggleVisibility_Click);
            // 
            // labelRegisterPrompt
            // 
            this.labelRegisterPrompt.AutoSize = true;
            this.labelRegisterPrompt.Location = new System.Drawing.Point(144, 420);
            this.labelRegisterPrompt.Name = "labelRegisterPrompt";
            this.labelRegisterPrompt.Size = new System.Drawing.Size(200, 16);
            this.labelRegisterPrompt.TabIndex = 7;
            this.labelRegisterPrompt.TabStop = true;
            this.labelRegisterPrompt.Text = "Don\'t have an account? Register";
            this.labelRegisterPrompt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelRegisterPrompt_LinkClicked);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Enabled = false;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.Location = new System.Drawing.Point(156, 356);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(179, 36);
            this.buttonSignIn.TabIndex = 8;
            this.buttonSignIn.Text = "Sign in";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelLoginFlavourText
            // 
            this.labelLoginFlavourText.AutoSize = true;
            this.labelLoginFlavourText.ForeColor = System.Drawing.Color.Red;
            this.labelLoginFlavourText.Location = new System.Drawing.Point(135, 226);
            this.labelLoginFlavourText.Name = "labelLoginFlavourText";
            this.labelLoginFlavourText.Size = new System.Drawing.Size(0, 16);
            this.labelLoginFlavourText.TabIndex = 9;
            // 
            // labelPasswordFlavourText
            // 
            this.labelPasswordFlavourText.AutoSize = true;
            this.labelPasswordFlavourText.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordFlavourText.Location = new System.Drawing.Point(135, 317);
            this.labelPasswordFlavourText.Name = "labelPasswordFlavourText";
            this.labelPasswordFlavourText.Size = new System.Drawing.Size(0, 16);
            this.labelPasswordFlavourText.TabIndex = 10;
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 484);
            this.Controls.Add(this.labelPasswordFlavourText);
            this.Controls.Add(this.labelLoginFlavourText);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelRegisterPrompt);
            this.Controls.Add(this.buttonToggleVisibility);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonToggleVisibility;
        private System.Windows.Forms.LinkLabel labelRegisterPrompt;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label labelLoginFlavourText;
        private System.Windows.Forms.Label labelPasswordFlavourText;
    }
}

