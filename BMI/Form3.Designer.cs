namespace BMI
{
    partial class FormBMI
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelUIAge = new System.Windows.Forms.Label();
            this.labelUIWeight = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.labelBMICondition = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(84, 26);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(173, 42);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Welcome";
            // 
            // labelUIAge
            // 
            this.labelUIAge.AutoSize = true;
            this.labelUIAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUIAge.Location = new System.Drawing.Point(90, 175);
            this.labelUIAge.Name = "labelUIAge";
            this.labelUIAge.Size = new System.Drawing.Size(59, 25);
            this.labelUIAge.TabIndex = 1;
            this.labelUIAge.Text = "Age: ";
            // 
            // labelUIWeight
            // 
            this.labelUIWeight.AutoSize = true;
            this.labelUIWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUIWeight.Location = new System.Drawing.Point(90, 254);
            this.labelUIWeight.Name = "labelUIWeight";
            this.labelUIWeight.Size = new System.Drawing.Size(85, 25);
            this.labelUIWeight.TabIndex = 2;
            this.labelUIWeight.Text = "Weight: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(87, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 22);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(183, 175);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(0, 25);
            this.labelAge.TabIndex = 4;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(181, 254);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(0, 25);
            this.labelWeight.TabIndex = 5;
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI.Location = new System.Drawing.Point(458, 171);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(148, 29);
            this.labelBMI.TabIndex = 6;
            this.labelBMI.Text = "Your BMI is: ";
            // 
            // labelBMICondition
            // 
            this.labelBMICondition.AutoSize = true;
            this.labelBMICondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMICondition.Location = new System.Drawing.Point(463, 254);
            this.labelBMICondition.Name = "labelBMICondition";
            this.labelBMICondition.Size = new System.Drawing.Size(0, 25);
            this.labelBMICondition.TabIndex = 7;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(181, 333);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(0, 25);
            this.labelHeight.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Height: ";
            // 
            // FormBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBMICondition);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelUIWeight);
            this.Controls.Add(this.labelUIAge);
            this.Controls.Add(this.labelLogin);
            this.Name = "FormBMI";
            this.Text = "BMI";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelUIAge;
        private System.Windows.Forms.Label labelUIWeight;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.Label labelBMICondition;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label label2;
    }
}