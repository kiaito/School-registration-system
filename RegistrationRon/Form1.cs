/**************
 * Levi Llewellyn
 * Lab#2
 Form
 **********/

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
    public partial class Form1 : Form
    {
        Section w = new Section();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            // Section s1;
            // s1 = new Section(746, "CIST2385", "Thursday 4.30", "f1150", 567);
            //s1.display();
            /*
            Schedule ss;
            ss = new Schedule();
            ss.add(new Section(746, "CIST2385", "thursday 4.30", "f1150", 768));
            ss.add(new Section(900, "CIST2677", "thursday 9.30", "f1189", 800));
            ss.display();*/
            Section s2;
            s2 = new Section();
            s2.SelectDB(746);
            s2.display();
            /*Section s3;
            s3 = new Section(746, "CIST2385", "TTH4-5pm", "f5550", 768);
            s3.InsertDB();*/
            //Section sc = new Section();
            //sc.SelectDB(746);
            //sc.setCourseID("fffff");
            //sc.setDaytime("tyyui");
            //sc.Upddate();
            //sc.DeleteDB();
            //sc.display();
        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            Course c1;
            c1 = new Course("CIST756", "Java 2", "advance java project", 4);
            c1.display();  
            Course c2;
            c2 = new Course();
            c2.SelectDB("CIST 3273");
            c2.display();*/
            //Course c3;
            // c3 = new Course("CIST 6677", "Intro to Python"," Beginner level intoduction to python syntax", 5);
            // c3.Upddate();
            //c3 = new Course("CIST 1313");
            //c3.SelectDB("CIST 1313");
            // c3.display();
            // c3.setCourseName("Levi best code up to date");
            //c3.setCreditHour(15);
            //c3.Upddate();
            Course c3 = new Course();
            c3.SelectDB("CIST 1313");
            c3.DeleteDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Address a1;
            a1 = new Address("806 summit plave drive", "Sandy spring", "georgia", 30188);
            a1.display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Person p1;
            p1 = new Person("kevin", "Davis", new Address("timberview", "atlanta", "georgia", 30188), "kdavis@gmail.com");
            // p1.display();
            p1.ss.add(new Section(746, "CIST2385", "thursday 4.30", "f1150", 768));
            p1.display();
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* Student ss1;
             ss1 = new Student(32, "jimboy", "Brono", new Address("summit place drive", "atlanta", "georgia", 30188), "Jbrono@gmail.com", 4.5);
             ss1.display(); */
            Student s2;
            s2 = new Student();
            s2.SelectDB(6);
            s2.display();
            /*Student s3;
            s3 = new Student(76, "Kevin", "Davis", new Address("162 timbelan", "Crooklyn", "Hawali", 34323), "walton@gmail.com", 5.7);
            s3.InsertDB();
            s3.display();*/
            /* Student s2;
            s2 = new  Student();
            s2.SelectDB(76);
            s2.setlname("Your moma");
            s2.setfname("Who me nah");
            s2.Upddate();
            s2.display(); */

        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* Instructor i1;
             i1 = new Instructor(43, "kevin", "hoit", new Address("timber", "atlanta", "georgia", 30188), "khoiut@gmail.com", 868);
             i1.display();*/
            /*
                        Instructor i1;
                        i1 = new Instructor();
                        i1.SelectDB(5);
                        i1.display();*/

            Instructor i2 = new Instructor();
            i2.SelectDB(90);

            i2.DeleteDB();

            /*
            Instructor s3;
            s3 = new Instructor(90, "Kevin", "Davis", new Address("162 timbelan", "Crooklyn", "Hawali", 34323),"walton@gmail.com", "b245");
            s3.InsertDB();
            s3.display();*/
        }
    }
}
