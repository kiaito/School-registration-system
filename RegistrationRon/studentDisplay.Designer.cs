﻿namespace RegistrationRon
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
            this.label1 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstNamelb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.crntb = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.crnBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // studentidlb
            // 
            this.studentidlb.AutoSize = true;
            this.studentidlb.Location = new System.Drawing.Point(7, 15);
            this.studentidlb.Name = "studentidlb";
            this.studentidlb.Size = new System.Drawing.Size(89, 13);
            this.studentidlb.TabIndex = 0;
            this.studentidlb.Text = "Enter Student ID:";
            // 
            // studentidtb
            // 
            this.studentidtb.Location = new System.Drawing.Point(99, 12);
            this.studentidtb.Name = "studentidtb";
            this.studentidtb.Size = new System.Drawing.Size(38, 20);
            this.studentidtb.TabIndex = 1;
            // 
            // submitid
            // 
            this.submitid.Location = new System.Drawing.Point(144, 9);
            this.submitid.Name = "submitid";
            this.submitid.Size = new System.Drawing.Size(75, 23);
            this.submitid.TabIndex = 2;
            this.submitid.Text = "Submit";
            this.submitid.UseVisualStyleBackColor = true;
            this.submitid.Click += new System.EventHandler(this.submitid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(126, 43);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Last Name";
            // 
            // firstNamelb
            // 
            this.firstNamelb.AutoSize = true;
            this.firstNamelb.Location = new System.Drawing.Point(42, 43);
            this.firstNamelb.Name = "firstNamelb";
            this.firstNamelb.Size = new System.Drawing.Size(54, 13);
            this.firstNamelb.TabIndex = 5;
            this.firstNamelb.Text = "FirstName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Crn";
            // 
            // crntb
            // 
            this.crntb.Location = new System.Drawing.Point(198, 295);
            this.crntb.Name = "crntb";
            this.crntb.Size = new System.Drawing.Size(100, 20);
            this.crntb.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(271, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(253, 147);
            this.listBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // crnBox
            // 
            this.crnBox.FormattingEnabled = true;
            this.crnBox.Items.AddRange(new object[] {
            "30101",
            "30102",
            "30103",
            "30104",
            "30105",
            "30106",
            "30108",
            "30109",
            "30110",
            "30111",
            "30112",
            "30113",
            "30114",
            "30115",
            "30116",
            "31107"});
            this.crnBox.Location = new System.Drawing.Point(161, 180);
            this.crnBox.Name = "crnBox";
            this.crnBox.Size = new System.Drawing.Size(121, 21);
            this.crnBox.TabIndex = 11;
            this.crnBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.crnBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.crntb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstNamelb);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstNamelb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox crntb;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox crnBox;
    }
}