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
    public partial class InstructorControl : Form
    {
        public InstructorControl()
        {
            InitializeComponent();
        }

        //Declarations
        Instructor intr;
        int sidy;
        string fname, lname, street, city, state, email, office;


        private void studentidlb_Click(object sender, EventArgs e)
        {

        }
        private void studentidtb_TextChanged(object sender, EventArgs e)
        {

        }

        //Delete button
        private void dropC_Click(object sender, EventArgs e)
        {
            //Deleting Student from database
            try
            {
                intr.SelectDB(sidy);
                intr.DeleteDB();
                MessageBox.Show("Instructor Data Deletion Successful!");
            }
            catch (Exception are)
            {
                MessageBox.Show(are.ToString());
            }
        }

        //update button
        private void button2_Click(object sender, EventArgs e)
        {
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
                office = officetb.Text;

                //Checking each textbox for a value
                if (fname.Equals("") || lname.Equals("") || sidy.Equals("") || street.Equals("") || city.Equals("")
                    || zip.Equals("") || email.Equals("") || office.Equals(""))
                {
                    MessageBox.Show("Make sure all fields are filled out");
                }
                else
                {//Setting values and Updating student into database

                    //ss1.SelectDB(sidy);
                    intr.setfname(fsnametb.Text);
                    intr.setlname(lname);
                    intr.a1.setstreet(street);
                    intr.a1.setcity(city);
                    intr.a1.setstate(state);
                    intr.a1.setzip(zip);
                    intr.setemail(email);
                    intr.setofficeNum(office);
                    intr.display();
                    intr.Upddate();

                    MessageBox.Show("Instructor Data Updated Successful!");
                }

            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }
        }

        Double zip;

        //Add instructor button
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
                office = officetb.Text;
                email = emailtb.Text;
               

                //Checking each textbox for a value
                if (fname.Equals("") || lname.Equals("") || sidy.Equals("") || street.Equals("") || city.Equals("")
                    || zip.Equals("") || email.Equals("") || office.Equals(""))
                {
                    MessageBox.Show("Make sure all fields are filled out");
                }
                else
                {//Input new instructor into database
             
                    Instructor ss1;
             ss1 = new Instructor(sidy, fname, lname, new Address(street, city, state, zip), office, email);
             ss1.display();
                    ss1.InsertDB();


                    MessageBox.Show("New Instructor Added Successful!");
                }

            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }




        }//end of add class button
    

        

        //Enter Button
        private void submitid_Click(object sender, EventArgs e)
        {
            //Clearing all textboxes
            listBox1.Items.Clear();
            sidd.Text = "";
            fsnametb.Text = "";
            slnametb.Text = "";
            streetlb.Text = "";
            citytb.Text = "";
            statetb.Text = "";
            ziptb.Text = "";
            emailtb.Text = "";
            officetb.Text = "";
            try
            {
                //accessing the database by Instructor id.
                int iid = Int32.Parse(studentidtb.Text);
                Instructor s1 = new Instructor();
                s1.SelectDB(iid);
                s1.display();
                intr = s1;

                //assigning the data to the textboxes
                sidd.Text = s1.getiid().ToString();
                fsnametb.Text = s1.getfname();
                slnametb.Text = s1.getlname();

                //getting the street city and zip from address object.
                Address ad = new Address();
                streettb.Text = s1.a1.getstreet();
                citytb.Text = s1.a1.getcity();
                statetb.Text = s1.a1.getstate();
                ziptb.Text = s1.a1.getzip().ToString();
                officetb.Text = s1.getofficeNum().ToString();
                emailtb.Text = s1.getemail();
                

                //Assigning textbox data to var
                sidy = Int32.Parse(studentidtb.Text);
                fname = fsnametb.Text;
                lname = slnametb.Text;
                street = streettb.Text;
                city = citytb.Text;
                state = statetb.Text;
                zip = Double.Parse(ziptb.Text);
                email = emailtb.Text;
                office = officetb.Text;


                
                
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

