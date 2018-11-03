using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*****************************
 * Author: Levi Llewellyn
 * Date Created 10/2018
 * Instructors Controls 
 *****************************/
namespace RegistrationRon
{
    public partial class SectionControl : Form
    {
        public SectionControl()
        {
            InitializeComponent();
        }
        Section sw;
        string cid, tday, roomno;
        int its, crnn;

        private void credithourlb_Click(object sender, EventArgs e)
        {

        }

        private void submitid_Click(object sender, EventArgs e)
        {
            //Clearing all textboxes
            listBox1.Items.Clear();
            crntb.Text = "";
            cidtb.Text = "";
            tdaytb.Text = "";
            roomnotb.Text = "";
            instb.Text = "";
            try
            {
                //accessing the database by  crn.
                crnn = Int32.Parse(Sectioncrntb.Text);
                Section s1 = new Section();
                s1.SelectDB(crnn);
                s1.display();
                sw = s1;

                //assigning the data to the textboxes
                crntb.Text = sw.getCrn().ToString();
                cidtb.Text = sw.getCourseID();
                tdaytb.Text = sw.getDaytime();
                roomnotb.Text = sw.getroom();
                its = sw.getinstructorID();

                //Getting instructor object
                Instructor it = new Instructor();
                it.SelectDB(its);
                instb.Text = it.getfname() + "   " + it.getlname();
                intemailtb.Text = it.getemail();



                //Assigning textbox data to var
                crnn = Int32.Parse(crntb.Text);
               cid =  cidtb.Text;
                tday =  tdaytb.Text;
                roomno = roomnotb.Text;
                its = Int32.Parse(instb.Text);




                //Getting schedule
                int c = s1.ss.count;
                for (int i = 0; i < c; i++)
                { 
                    string n1 = s1.ss.sec[i].getCrn() + " " + s1.ss.sec[i].getCourseID() + " " + s1.ss.sec[i].getDaytime() +
                         " " + s1.ss.sec[i].getroom() + " " + s1.ss.sec[i].getinstructorID();

                    listBox1.Items.Add(n1);
                }
                //}//end for

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
