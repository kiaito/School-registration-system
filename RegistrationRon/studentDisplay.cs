﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationRon
{
    public partial class studentDisplay : Form
    {
        public studentDisplay()
        {
            InitializeComponent();
        }

        private void studentDisplay_Load(object sender, EventArgs e)
        {

        }

        private void submitid_Click(object sender, EventArgs e)
        {
            try
            {

                int sid = Int32.Parse(studentidtb.Text);

                Student s1 = new Student();
                s1.SelectDB(sid);
                s1.display();
                
                firstNamelb.Text = s1.getfname();
                lastName.Text = s1.getlname();

                int c = s1.ss.count;
                //for
              string n1 = s1.ss.sec[0].getCrn() + " "+ s1.ss.sec[0].getCourseID();

                    listBox1.Items.Add(n1);
                //}//end for
                        
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
