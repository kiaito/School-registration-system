namespace RegistrationRon
{
    partial class studentDisplay
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
            this.studentidlb = new System.Windows.Forms.Label();
            this.studentidtb = new System.Windows.Forms.TextBox();
            this.submitid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentidlb
            // 
            this.studentidlb.AutoSize = true;
            this.studentidlb.Location = new System.Drawing.Point(12, 15);
            this.studentidlb.Name = "studentidlb";
            this.studentidlb.Size = new System.Drawing.Size(89, 13);
            this.studentidlb.TabIndex = 0;
            this.studentidlb.Text = "Enter Student ID:";
            // 
            // studentidtb
            // 
            this.studentidtb.Location = new System.Drawing.Point(119, 12);
            this.studentidtb.Name = "studentidtb";
            this.studentidtb.Size = new System.Drawing.Size(100, 20);
            this.studentidtb.TabIndex = 1;
            // 
            // submitid
            // 
            this.submitid.Location = new System.Drawing.Point(119, 38);
            this.submitid.Name = "submitid";
            this.submitid.Size = new System.Drawing.Size(75, 23);
            this.submitid.TabIndex = 2;
            this.submitid.Text = "Submit";
            this.submitid.UseVisualStyleBackColor = true;
            // 
            // studentDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.submitid);
            this.Controls.Add(this.studentidtb);
            this.Controls.Add(this.studentidlb);
            this.Name = "studentDisplay";
            this.Text = "studentDisplay";
            this.Load += new System.EventHandler(this.studentDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentidlb;
        private System.Windows.Forms.TextBox studentidtb;
        private System.Windows.Forms.Button submitid;
    }
}