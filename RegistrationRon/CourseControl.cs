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
 * Course Controls 
 *****************************/
namespace RegistrationRon
{
    public partial class CourseControl : Form
    {
        public CourseControl()
        {
            InitializeComponent();
        }
        public CourseControl(string cd1)
        {
            course1 = cd1;
        }
        Course sub;
        string cid, cname, cdesc;
        int chour;
        string course1;
        private void button1_Click(object sender, EventArgs e)
        {
            //Assigning textboxs values to var
            try
            {
                cid = cidtb.Text;
                cname = cnametb.Text;
                cdesc = destb.Text;
                chour = Int32.Parse(chtb.Text);
                

                //Checking each textbox for a value
                if (cid.Equals("") || cname.Equals("") || cdesc.Equals("") || chour.Equals("") )
                    
                {
                    MessageBox.Show("Make sure all fields are filled out");
                }
                else
                {//Input new instructor into database

                    Course sub;
                    sub = new Course(cid, cname, cdesc, chour);
                    sub.display();
                    sub.InsertDB();
                    MessageBox.Show("New Course Added Successful!");
                }
            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }
        }

        private void CourseControl_Load(object sender, EventArgs e)
        {
           // listBox1.Items.Add(course1);
        }
        private void dropC_Click(object sender, EventArgs e)
        {
            try
            {
                sub.SelectDB(cid);
                sub.DeleteDB();
                MessageBox.Show("Course Data Deletion Successful!");
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
            SectionControl scc = new SectionControl();
            this.Hide();
            scc.Show();
        }

        private void InstructorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InstructorControl ic = new InstructorControl();
            this.Hide();
            ic.Show();
        }

        //The update button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cid = cidtb.Text;
                cname = cnametb.Text;
                cdesc = destb.Text;
                chour = Int32.Parse(chtb.Text);

                //Checking each textbox for a value
                if (cid.Equals("") || cname.Equals("") || cdesc.Equals("") || chour.Equals(""))

                {
                    MessageBox.Show("Make sure all fields are filled out");
                }
                else
                {//Setting values and Updating Courses into database   
                    sub.setCourseID(cid);
                    sub.setCourseName(cname);
                    sub.setDescription(cdesc);
                    sub.setCreditHour(chour);
                    sub.display();
                    sub.Upddate();
                    MessageBox.Show("Course Data Updated Successful!");
                }
            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }
        }
        //Enter Button
        private void submitid_Click(object sender, EventArgs e)
        {
            try
            {
                //Clearing all textboxes
                listBox1.Items.Clear();
                cidtb.Text = "";
                cnametb.Text = "";
                destb.Text = "";
                chtb.Text = "";

                //accessing the database by Course id.
                string ccid = Courseidtb.Text;
                Course s1 = new Course();
                s1.SelectDB(ccid);
                s1.display();
                sub = s1;

                //Assigning data to textboxes
                cidtb.Text = s1.getCourseID();
                cnametb.Text = s1.getCourseName();
                destb.Text = s1.getDescription();
                chtb.Text = s1.getCreditHour().ToString();

                //Assigning textbox data to vars
                cid = cidtb.Text;
                cname = cnametb.Text;
                cdesc = destb.Text;
                chour = Int32.Parse(chtb.Text);


                //Getting courses
                int c = s1.ssy.count;
                
                for (int i = 0; i < c; i++)
                {
                    string n1 = s1.ssy.arc[i].getCourseID() + " " + s1.ssy.arc[i].getCourseName() + " " + s1.ssy.arc[i].getCreditHour() +
                        " " + s1.ssy.arc[i].getDescription();

                    //s1.ss.sec[i].getCrn() + " " + s1.ss.sec[i].getCourseID() + " " + s1.ss.sec[i].getDaytime() +
                    // " " + s1.ss.sec[i].getroom() + " " + s1.ss.sec[i].getinstructorID();
                    Console.WriteLine(s1.ssy.arc[i].getCourseName());
                    listBox1.Items.Add(n1);
                }
            }
            catch(Exception ad)
            {
                Console.WriteLine(ad);
            }
            //}//end for
        }
    }
}
