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

                nametb.Text = s1.getfname() +" "+ s1.getlname();
                //lastnametb.Text = s1.getlname();
                emailtb.Text = s1.getemail();
                gpatb.Text = s1.getgpa().ToString();

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
            ww.Insertsch(Int32.Parse(roomtb.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Section ss1 = new Section();
            string comb = crnBox.Text;

          ss1.SelectDB(Int32.Parse(comb));

            Course cc1 = new Course();
            cc1.SelectDB(ss1.getCourseID());
            courseidtb.Text = cc1.getCourseID();
            cnametb.Text =  cc1.getCourseName();
            desctb.Text = cc1.getDescription();
            timedtb.Text = ss1.getDaytime();
            roomtb.Text = ss1.getroom();

            Instructor in1 = new Instructor();
            in1.SelectDB(ss1.getinstructorID());
            intb.Text = in1.getfname() + in1.getlname();
          //crn
          //course1d 
          //room/days
            ss1.display();
        }

        private void firstNamelb_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addresstb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void crntb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
