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
    public partial class StudentControl : Form
    {
        public StudentControl()
        {
            InitializeComponent();
        }
        //Declariations
        Student ww;
        int sidy;
        string fname, lname, street, city, state, email;
        double zip, gpa;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitid_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                //accessing the database by student id.
                int sid = Int32.Parse(studentidtb.Text);
                Student s1 = new Student();
                s1.SelectDB(sid);
                s1.display();
                ww = s1;

                //assigning the data to the textboxes
                sidd.Text = s1.getsid().ToString();
                fsnametb.Text = s1.getfname();
                slnametb.Text = s1.getlname();

                //getting the street city and zip from address object.
                Address ad = new Address();
                streettb.Text = s1.a1.getstreet();
                citytb.Text = s1.a1.getcity();
                statetb.Text = s1.a1.getstate();
                ziptb.Text = s1.a1.getzip().ToString();
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void emailtb_TextChanged(object sender, EventArgs e)
        {

        }
        //Update button
        private void button2_Click(object sender, EventArgs e)
        {
            //Assigning textboxs values to var
            try
            {
                sidy = Int32.Parse(studentidtb.Text);
                fname = fsnametb.Text;
                lname = slnametb.Text;
                street = streettb.Text;
                city = citytb.Text;
                state = statetb.Text;
                zip = Double.Parse(ziptb.Text);
                email = emailtb.Text;
                gpa = Double.Parse(gpatb.Text);

                //Checking each textbox for a value
                if (fname.Equals("") || lname.Equals("") || sidy.Equals("") || street.Equals("") || city.Equals("")
                    || zip.Equals("") || email.Equals("") || gpa.Equals(""))
                {
                    MessageBox.Show("Make sure all fields are filled out");
                }
                else
                {//Updating student into database
                    Student ss2 = new Student();
                    ss2.SelectDB(sidy);
                    ss2.setfname(fname);
                    ss2.setlname(lname);
                    ss2.a1.setstreet(street);
                    ss2.a1.setcity(city);
                    ss2.a1.setstate(state);
                    ss2.a1.setzip(zip);
                    ss2.setemail(email);
                    ss2.setgpa(gpa);
                    ss2.display();
                    ss2.SelectDB(sidy);
                  
                    ss2.Upddate();

                    MessageBox.Show(sidy + fname +lname);
                }

            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void roomtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ziptb_TextChanged(object sender, EventArgs e)
        {

        }

        private void streetlb_Click(object sender, EventArgs e)
        {

        }
        //The Add class button
        private void button1_Click(object sender, EventArgs e)
        {
            //Assigning textboxs values to var
            try
            {
                sidy = Int32.Parse(sidd.Text);
                fname = fsnametb.Text;
                lname = slnametb.Text;
                street = streettb.Text;
                city = citytb.Text;
                state = statetb.Text;
                zip = Double.Parse(ziptb.Text);
                email = emailtb.Text;
                gpa = Double.Parse(gpatb.Text);

                //Checking each textbox for a value
                if (fname.Equals("") || lname.Equals("") || sidy.Equals("") || street.Equals("") || city.Equals("")
                    || zip.Equals("") || email.Equals("") || gpa.Equals(""))
                {
                    MessageBox.Show("Make sure all fields are filled out");
                }
                else
                {//Input new student into database
                    Student ss1;
                    ss1 = new Student(sidy, fname, lname, new Address(street, city, state, zip), email, gpa);
                    ss1.display();
                    ss1.InsertDB();

                    MessageBox.Show("New Student Added Successful!");
                }

            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }




        }//end of add class button
    }//End of class
}
