namespace RegistrationRon
{
    partial class Loginform
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
            this.userNamelb = new System.Windows.Forms.Label();
            this.Passwordlb = new System.Windows.Forms.Label();
            this.Pwtb = new System.Windows.Forms.TextBox();
            this.Usertb = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pleaseenterlb = new System.Windows.Forms.Label();
            this.whenfinishlb = new System.Windows.Forms.Label();
            this.YourPinlb = new System.Windows.Forms.Label();
            this.mainlabelb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNamelb
            // 
            this.userNamelb.AutoSize = true;
            this.userNamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamelb.Location = new System.Drawing.Point(10, 221);
            this.userNamelb.Name = "userNamelb";
            this.userNamelb.Size = new System.Drawing.Size(56, 16);
            this.userNamelb.TabIndex = 0;
            this.userNamelb.Text = "User ID:";
            // 
            // Passwordlb
            // 
            this.Passwordlb.AutoSize = true;
            this.Passwordlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlb.Location = new System.Drawing.Point(10, 249);
            this.Passwordlb.Name = "Passwordlb";
            this.Passwordlb.Size = new System.Drawing.Size(71, 16);
            this.Passwordlb.TabIndex = 1;
            this.Passwordlb.Text = "Password:";
            this.Passwordlb.Click += new System.EventHandler(this.Passwordlb_Click);
            // 
            // Pwtb
            // 
            this.Pwtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwtb.Location = new System.Drawing.Point(85, 246);
            this.Pwtb.Name = "Pwtb";
            this.Pwtb.Size = new System.Drawing.Size(220, 22);
            this.Pwtb.TabIndex = 2;
            this.Pwtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Usertb
            // 
            this.Usertb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertb.Location = new System.Drawing.Point(85, 218);
            this.Usertb.Name = "Usertb";
            this.Usertb.Size = new System.Drawing.Size(220, 22);
            this.Usertb.TabIndex = 1;
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(205, 290);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(100, 29);
            this.submitbtn.TabIndex = 4;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(85, 290);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 29);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Pleaseenterlb);
            this.groupBox1.Controls.Add(this.whenfinishlb);
            this.groupBox1.Controls.Add(this.YourPinlb);
            this.groupBox1.Controls.Add(this.mainlabelb);
            this.groupBox1.Controls.Add(this.Usertb);
            this.groupBox1.Controls.Add(this.Reset);
            this.groupBox1.Controls.Add(this.userNamelb);
            this.groupBox1.Controls.Add(this.submitbtn);
            this.groupBox1.Controls.Add(this.Passwordlb);
            this.groupBox1.Controls.Add(this.Pwtb);
            this.groupBox1.Location = new System.Drawing.Point(92, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 342);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 60);
            this.label4.TabIndex = 10;
            this.label4.Text = "The privacy of student information held by ABC is protected\r\n by federal law, the" +
    " Family Educational Act of 1974, as\r\n amended by FERPA.\r\n\r\n";
            // 
            // Pleaseenterlb
            // 
            this.Pleaseenterlb.AutoSize = true;
            this.Pleaseenterlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pleaseenterlb.Location = new System.Drawing.Point(7, 59);
            this.Pleaseenterlb.Name = "Pleaseenterlb";
            this.Pleaseenterlb.Size = new System.Drawing.Size(318, 15);
            this.Pleaseenterlb.TabIndex = 9;
            this.Pleaseenterlb.Text = "Please enter your Student / Faculty Number and your PIN.";
            // 
            // whenfinishlb
            // 
            this.whenfinishlb.AutoSize = true;
            this.whenfinishlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whenfinishlb.Location = new System.Drawing.Point(10, 121);
            this.whenfinishlb.Name = "whenfinishlb";
            this.whenfinishlb.Size = new System.Drawing.Size(146, 15);
            this.whenfinishlb.TabIndex = 8;
            this.whenfinishlb.Text = "When finish, select Login.";
            // 
            // YourPinlb
            // 
            this.YourPinlb.AutoSize = true;
            this.YourPinlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourPinlb.Location = new System.Drawing.Point(10, 89);
            this.YourPinlb.Name = "YourPinlb";
            this.YourPinlb.Size = new System.Drawing.Size(300, 15);
            this.YourPinlb.TabIndex = 7;
            this.YourPinlb.Text = "Your initial Password is student and admin respectivly.";
            // 
            // mainlabelb
            // 
            this.mainlabelb.AutoSize = true;
            this.mainlabelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabelb.Location = new System.Drawing.Point(8, 16);
            this.mainlabelb.Name = "mainlabelb";
            this.mainlabelb.Size = new System.Drawing.Size(233, 25);
            this.mainlabelb.TabIndex = 6;
            this.mainlabelb.Text = "Student / Faculty Login";
            this.mainlabelb.Click += new System.EventHandler(this.mainlabelb_Click);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "Loginform";
            this.Text = "Loginform";
            this.Load += new System.EventHandler(this.Loginform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNamelb;
        private System.Windows.Forms.Label Passwordlb;
        private System.Windows.Forms.TextBox Pwtb;
        private System.Windows.Forms.TextBox Usertb;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Pleaseenterlb;
        private System.Windows.Forms.Label whenfinishlb;
        private System.Windows.Forms.Label YourPinlb;
        private System.Windows.Forms.Label mainlabelb;
        private System.Windows.Forms.Label label4;
    }
}