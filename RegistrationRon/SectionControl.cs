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
        Section sw = new Section();
        string cid, tday, roomno;
        int its, crnn, intid;

        //update button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cid = cidtb.Text;
                tday = tdaytb.Text;
                roomno = roomnotb.Text;
                crnn = Int32.Parse(crntb.Text);
                intid = Int32.Parse(idtb.Text);

                //Checking each textbox for a value
                if (cid.Equals("") || tday.Equals("") || roomno.Equals("") || crnn.Equals("") || intid.Equals(""))

                {
                    MessageBox.Show("Make sure all fields are filled out");
                }

                else
                {//Setting values and Updating Sections into database   
                    sw.setCourseID(cid);
                    sw.setDaytime(tday);
                    sw.setroom(roomno);
                    sw.setCrn(crnn);
                    sw.setinstructorID(intid);
                    sw.Upddate();
                   
                    MessageBox.Show("Section Data Updated Successful!");
                }
            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }
        }

        private void dropC_Click(object sender, EventArgs e)
        {
            try
            {
                crnstb.Items.Remove(crnn);
                sw.SelectDB(crnn);
                sw.DeleteDB();
                MessageBox.Show("Section Data Deletion Successful!");
                sw.ss.delsec(sw);

            }
            catch (Exception are)
            {
                MessageBox.Show(are.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin an = new Admin();
            this.Hide();
            an.Show();
        }

        private void Studentlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentControl sc = new StudentControl();
            this.Hide();
            sc.Show();
        }

        private void SectionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InstructorControl inn = new InstructorControl();
            this.Hide();
            inn.Show();
        }

        private void CoursesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseControl cc = new CourseControl();
            this.Hide();
            cc.Show();
        }

        private void ResetAllFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cidtb.Text = "";
            tdaytb.Text = "";
            roomnotb.Text = "";
            crntb.Text = "";
            cidtb.Text = "";
            tdaytb.Text = "";
            roomnotb.Text = "";
            instb.Text = "";
            idtb.Text = "";
            intemailtb.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {//insert button
            //Assigning textboxs values to var
            try
            {
                cid = cidtb.Text;
                tday = tdaytb.Text;
                roomno = roomnotb.Text;
                crnn = Int32.Parse(crntb.Text);
                intid = Int32.Parse(idtb.Text);

                //Checking each textbox for a value
                if (cid.Equals("") || tday.Equals("") || roomno.Equals("") || crnn.Equals("") || intid.Equals(""))

                {
                    MessageBox.Show("Make sure all fields are filled out");
                }
                
                else
                {//Input new Section into database

                    Section sw;
                    sw = new Section(crnn, cid, tday, roomno, intid);
                    sw.display();
                    sw.InsertDB();
                    MessageBox.Show("New Section Added Successful!");
                    int temp = sw.getCrn();
                    crnstb.Items.Add(temp);
                }
            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }
        }

        private void Sectioncrntb_TextChanged(object sender, EventArgs e)
        {

        }

        private void credithourlb_Click(object sender, EventArgs e)
        {

        }
        //The enter button
        private void submitid_Click(object sender, EventArgs e)
        {
            //Clearing all textboxes
            listBox1.Items.Clear();
            crntb.Text = "";
            cidtb.Text = "";
            tdaytb.Text = "";
            roomnotb.Text = "";
            instb.Text = "";
            idtb.Text = "";
            instb.Text = "";
            intemailtb.Text = "";
            try
            {
                //accessing the database by  crn.
                crnn = Int32.Parse(crnstb.Text);
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
                idtb.Text = sw.getinstructorID().ToString();

                //Getting instructor object
                Instructor it = new Instructor();
                it.SelectDB(its);
                instb.Text = it.getfname() + "   " + it.getlname();
                intemailtb.Text = it.getemail();
                string intfname, intlname;
                intfname = it.getfname();
                intlname = it.getlname();


                //Assigning textbox data to var
                crnn = Int32.Parse(crntb.Text);
               cid =  cidtb.Text;
                tday =  tdaytb.Text;
                roomno = roomnotb.Text;
               // its = Int32.Parse(instb.Text);




                //Getting schedule
                int c = s1.ss.count;
                for (int i = 0; i < c; i++)
                { 
                    string n1 = s1.ss.sec[i].getCrn() + " " + s1.ss.sec[i].getCourseID() + " " + s1.ss.sec[i].getDaytime() +
                         " " + s1.ss.sec[i].getroom() + " " + s1.ss.sec[i].getinstructorID();

                    //listBox1.Items.Add(s1.getCrn());
                    //listBox1.Items.Add(n1);
                    listBox1.Items.Add("Feature Not Enable.");
                    MessageBox.Show("feature");
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
