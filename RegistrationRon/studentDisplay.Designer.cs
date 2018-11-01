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
            this.components = new System.ComponentModel.Container();
            this.studentidlb = new System.Windows.Forms.Label();
            this.studentidtb = new System.Windows.Forms.TextBox();
            this.submitid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.Namelb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.roomtb = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.crnBox = new System.Windows.Forms.ComboBox();
            this.timedtb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpatb = new System.Windows.Forms.TextBox();
            this.desclb = new System.Windows.Forms.Label();
            this.cnamelb = new System.Windows.Forms.Label();
            this.desctb = new System.Windows.Forms.TextBox();
            this.cnametb = new System.Windows.Forms.TextBox();
            this.courseidtb = new System.Windows.Forms.TextBox();
            this.crn = new System.Windows.Forms.Label();
            this.dropC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.intb = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentidlb
            // 
            this.studentidlb.AutoSize = true;
            this.studentidlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentidlb.Location = new System.Drawing.Point(9, 14);
            this.studentidlb.Name = "studentidlb";
            this.studentidlb.Size = new System.Drawing.Size(106, 16);
            this.studentidlb.TabIndex = 0;
            this.studentidlb.Text = "Enter Student ID:";
            // 
            // studentidtb
            // 
            this.studentidtb.Location = new System.Drawing.Point(116, 11);
            this.studentidtb.Name = "studentidtb";
            this.studentidtb.Size = new System.Drawing.Size(38, 20);
            this.studentidtb.TabIndex = 1;
            // 
            // submitid
            // 
            this.submitid.Location = new System.Drawing.Point(161, 9);
            this.submitid.Name = "submitid";
            this.submitid.Size = new System.Drawing.Size(75, 23);
            this.submitid.TabIndex = 2;
            this.submitid.Text = "Enter";
            this.submitid.UseVisualStyleBackColor = true;
            this.submitid.Click += new System.EventHandler(this.submitid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Schedule";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(14, 16);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(70, 16);
            this.lastName.TabIndex = 4;
            this.lastName.Text = "Course ID:";
            this.lastName.Click += new System.EventHandler(this.lastName_Click);
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelb.Location = new System.Drawing.Point(9, 43);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(48, 16);
            this.Namelb.TabIndex = 5;
            this.Namelb.Text = "Name:";
            this.Namelb.Click += new System.EventHandler(this.firstNamelb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Avaiable Classes";
            // 
            // roomtb
            // 
            this.roomtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtb.Location = new System.Drawing.Point(90, 118);
            this.roomtb.Name = "roomtb";
            this.roomtb.Size = new System.Drawing.Size(186, 22);
            this.roomtb.TabIndex = 8;
            this.roomtb.TextChanged += new System.EventHandler(this.crntb_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(259, 84);
            this.listBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 115);
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
            this.crnBox.Location = new System.Drawing.Point(63, 39);
            this.crnBox.Name = "crnBox";
            this.crnBox.Size = new System.Drawing.Size(153, 21);
            this.crnBox.TabIndex = 11;
            this.crnBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timedtb
            // 
            this.timedtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timedtb.Location = new System.Drawing.Point(90, 90);
            this.timedtb.Name = "timedtb";
            this.timedtb.Size = new System.Drawing.Size(186, 22);
            this.timedtb.TabIndex = 12;
            // 
            // nametb
            // 
            this.nametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametb.Location = new System.Drawing.Point(63, 43);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(173, 22);
            this.nametb.TabIndex = 13;
            // 
            // emailtb
            // 
            this.emailtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtb.Location = new System.Drawing.Point(63, 71);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(173, 22);
            this.emailtb.TabIndex = 14;
            this.emailtb.TextChanged += new System.EventHandler(this.addresstb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "GPA:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // gpatb
            // 
            this.gpatb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpatb.Location = new System.Drawing.Point(63, 100);
            this.gpatb.Name = "gpatb";
            this.gpatb.Size = new System.Drawing.Size(173, 22);
            this.gpatb.TabIndex = 17;
            // 
            // desclb
            // 
            this.desclb.AutoSize = true;
            this.desclb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclb.Location = new System.Drawing.Point(5, 62);
            this.desclb.Name = "desclb";
            this.desclb.Size = new System.Drawing.Size(79, 16);
            this.desclb.TabIndex = 18;
            this.desclb.Text = "Description:";
            this.desclb.Click += new System.EventHandler(this.label6_Click);
            // 
            // cnamelb
            // 
            this.cnamelb.AutoSize = true;
            this.cnamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnamelb.Location = new System.Drawing.Point(33, 39);
            this.cnamelb.Name = "cnamelb";
            this.cnamelb.Size = new System.Drawing.Size(51, 16);
            this.cnamelb.TabIndex = 19;
            this.cnamelb.Text = "Name :";
            // 
            // desctb
            // 
            this.desctb.Location = new System.Drawing.Point(90, 62);
            this.desctb.Multiline = true;
            this.desctb.Name = "desctb";
            this.desctb.Size = new System.Drawing.Size(186, 20);
            this.desctb.TabIndex = 20;
            // 
            // cnametb
            // 
            this.cnametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnametb.Location = new System.Drawing.Point(90, 36);
            this.cnametb.Name = "cnametb";
            this.cnametb.Size = new System.Drawing.Size(186, 22);
            this.cnametb.TabIndex = 21;
            // 
            // courseidtb
            // 
            this.courseidtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidtb.Location = new System.Drawing.Point(90, 11);
            this.courseidtb.Name = "courseidtb";
            this.courseidtb.Size = new System.Drawing.Size(186, 22);
            this.courseidtb.TabIndex = 22;
            // 
            // crn
            // 
            this.crn.AutoSize = true;
            this.crn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crn.Location = new System.Drawing.Point(19, 42);
            this.crn.Name = "crn";
            this.crn.Size = new System.Drawing.Size(38, 16);
            this.crn.TabIndex = 23;
            this.crn.Text = "Crn #";
            // 
            // dropC
            // 
            this.dropC.Location = new System.Drawing.Point(63, 126);
            this.dropC.Name = "dropC";
            this.dropC.Size = new System.Drawing.Size(153, 38);
            this.dropC.TabIndex = 24;
            this.dropC.Text = "Drop Class";
            this.dropC.UseVisualStyleBackColor = true;
            this.dropC.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 160);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nametb);
            this.groupBox4.Controls.Add(this.studentidlb);
            this.groupBox4.Controls.Add(this.emailtb);
            this.groupBox4.Controls.Add(this.gpatb);
            this.groupBox4.Controls.Add(this.studentidtb);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Namelb);
            this.groupBox4.Controls.Add(this.submitid);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(6, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 134);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(254, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 134);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(8, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 192);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.dropC);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.crn);
            this.groupBox5.Controls.Add(this.crnBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 179);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.intb);
            this.groupBox6.Controls.Add(this.courseidtb);
            this.groupBox6.Controls.Add(this.cnamelb);
            this.groupBox6.Controls.Add(this.desclb);
            this.groupBox6.Controls.Add(this.lastName);
            this.groupBox6.Controls.Add(this.desctb);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.timedtb);
            this.groupBox6.Controls.Add(this.cnametb);
            this.groupBox6.Controls.Add(this.roomtb);
            this.groupBox6.Location = new System.Drawing.Point(254, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(282, 180);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Instructor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Room No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Time Days:";
            // 
            // intb
            // 
            this.intb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intb.Location = new System.Drawing.Point(90, 147);
            this.intb.Name = "intb";
            this.intb.Size = new System.Drawing.Size(186, 22);
            this.intb.TabIndex = 25;
            this.intb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // studentDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(567, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "studentDisplay";
            this.Text = "studentDisplay";
            this.Load += new System.EventHandler(this.studentDisplay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label studentidlb;
        private System.Windows.Forms.TextBox studentidtb;
        private System.Windows.Forms.Button submitid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label Namelb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomtb;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox crnBox;
        private System.Windows.Forms.TextBox timedtb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gpatb;
        private System.Windows.Forms.Label desclb;
        private System.Windows.Forms.Label cnamelb;
        private System.Windows.Forms.TextBox desctb;
        private System.Windows.Forms.TextBox cnametb;
        private System.Windows.Forms.TextBox courseidtb;
        private System.Windows.Forms.Label crn;
        private System.Windows.Forms.Button dropC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox intb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}