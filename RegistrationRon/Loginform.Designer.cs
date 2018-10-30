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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNamelb
            // 
            this.userNamelb.AutoSize = true;
            this.userNamelb.Location = new System.Drawing.Point(136, 113);
            this.userNamelb.Name = "userNamelb";
            this.userNamelb.Size = new System.Drawing.Size(60, 13);
            this.userNamelb.TabIndex = 0;
            this.userNamelb.Text = "UserName:";
            // 
            // Passwordlb
            // 
            this.Passwordlb.AutoSize = true;
            this.Passwordlb.Location = new System.Drawing.Point(136, 154);
            this.Passwordlb.Name = "Passwordlb";
            this.Passwordlb.Size = new System.Drawing.Size(56, 13);
            this.Passwordlb.TabIndex = 1;
            this.Passwordlb.Text = "Password:";
            this.Passwordlb.Click += new System.EventHandler(this.Passwordlb_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(198, 190);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 4;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Passwordlb);
            this.Controls.Add(this.userNamelb);
            this.Name = "Loginform";
            this.Text = "Loginform";
            this.Load += new System.EventHandler(this.Loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNamelb;
        private System.Windows.Forms.Label Passwordlb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button submitbtn;
    }
}