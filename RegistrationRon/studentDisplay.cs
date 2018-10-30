using System;
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

        Student ww;

        private void studentDisplay_Load(object sender, EventArgs e)
        {

        }

        private void submitid_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {

                int sid = Int32.Parse(studentidtb.Text);
                Student s1 = new Student();
                s1.SelectDB(sid);
                s1.display();
                ww = s1;
                
                firstNamelb.Text = s1.getfname();
                lastName.Text = s1.getlname();


                int c = s1.ss.count;
                for (int i = 0; i < c; i++)
                {
                    string n1 = s1.ss.sec[i].getCrn() + " " + s1.ss.sec[i].getCourseID() + " " + s1.ss.sec[i].getDaytime() +
                         " " + s1.ss.sec[i].getroom() + " " + s1.ss.sec[i].getinstructorID();
                    
                    listBox1.Items.Add(n1);
                }
                //}//end for
                        
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ww.Insertsch(Int32.Parse(crntb.Text));
        }
    }
}
