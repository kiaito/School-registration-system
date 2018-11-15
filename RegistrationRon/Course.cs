/**************
 * Levi Llewellyn
 * Lab#2
 Courses Class
 **********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationRon
{
    class Course
        //------------Properties-----------//
    {
        public string CourseID;
        public string CourseName;
        public string Description;
        public int CreditHour;
        public Schedule ssy = new Schedule();
        string course1;

        //--------constructors---------//
        public Course()
        {
            CourseID = "";
            CourseName = "";
            Description = "";
            CreditHour = 0;
        }
        public Course(string cid, string cn, string des, int ch)
        {
            CourseID = cid;
            CourseName = cn;
            Description = des;
            CreditHour = ch;
        }

        public Course(string id)
        {
            SelectDB(id);
        }
        //-----------Getters and Setters---------//
        public void setCourseID(string cid) { CourseID = cid; }
        public string getCourseID() { return CourseID; }

        public void setCourseName(string cn) { CourseName = cn; }
        public string getCourseName() { return CourseName; }

        public void setDescription(string des) { Description = des; }
        public string getDescription() { return Description; }

        public void setCreditHour(int ch) { CreditHour = ch; }
        public int getCreditHour() { return CreditHour; }



        //---------Display --------//
        public void display()
        {
            Console.WriteLine("CourseID = " + getCourseID());
            Console.WriteLine("Course Name = " + getCourseName());
            Console.WriteLine("Description = " + getDescription());
            Console.WriteLine("Credit Hour = " + getCreditHour());
        }

        //---------BEHAVIOR---------//
        public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        public System.Data.OleDb.OleDbCommand OleDbSelectCommand;
        public System.Data.OleDb.OleDbCommand OleDbInsertCommand;
        public System.Data.OleDb.OleDbCommand OleDbUpdateCommand;
        public System.Data.OleDb.OleDbCommand OleDbDeleteCommand;
        public System.Data.OleDb.OleDbConnection OleDbConnection;
        public string cmd;


        //---------Database Setup -------//
        public void DBSetup()
        {
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand = new System.Data.OleDb.OleDbCommand();
            OleDbConnection = new System.Data.OleDb.OleDbConnection();


            OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand;
            OleDbDataAdapter2.InsertCommand = OleDbInsertCommand;
            OleDbDataAdapter2.SelectCommand = OleDbSelectCommand;
            OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand;


            OleDbConnection.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=c:\\Users\\grob1\\Documents\\RegistrationMDB.mdb;J" + 
			"et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" + 
			"ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" + 
			"hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " + 
			"OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" + 
			"r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        } //end DB setup

        //----Select Database Connection-----//
        public void SelectDB(string id)
        {
            DBSetup();
            cmd = "Select * from Courses where CourseID = '" + id + "'";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                CourseID = id;
                setCourseName(dr.GetValue(1) + "");
                setDescription(dr.GetValue(2) + "");
                setCreditHour(Int32.Parse(dr.GetValue(3) + ""));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection.Close();
            }
            //GetcList();
            SelectDBt();
            // end SelectDB
        }

       public void SelectDBt()
        {
            //Course s1 = new Course();
            DBSetup();
            cmd = "Select * from Courses";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();
               // string lines = "";
                while (dr.Read())
                {
                    // dr.Read();
                    string cc1, cc2, cc3, cc4;
                    Course c2 = new Course();
                    setCourseID(dr.GetValue(0) + "");
                    setCourseName(dr.GetValue(1) + "");
                    setDescription(dr.GetValue(2) + "");
                    setCreditHour(Int32.Parse(dr.GetValue(3) + ""));
                    //hfskhfksf
                    cc1 = c2.getCourseID();
                    cc2 = c2.getCourseName();

                    //course1 = cc1 + cc2;
                    //CourseControl s1 = new CourseControl(course1);
                   //ssy.addc(c2);
                   // c2.display();
                   

                   // c2.tostring  then add to listbox
                }
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection.Close();
            }
            //GetcList();
            // end SelectDB
        }
    
           


        public void GetcList()
         {

             cmd = "Select * from Courses where CourseID = '" + CourseID + "'";
             OleDbDataAdapter2.SelectCommand.CommandText = cmd;
             OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;
             Console.WriteLine(cmd);
             string crid = "";
             Course s1 = new Course();
             try
             {

                 OleDbConnection.Open();
                 System.Data.OleDb.OleDbDataReader dr;
                 dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();
                string liner = "";
                while (dr.Read())
                
                 {
                     crid = dr.GetValue(0) + "";
                     s1 = new Course();

                     s1.SelectDB(crid);
                     ssy.addc(s1);
                 }
                
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex);
             }
             finally
             {
                 OleDbConnection.Close();
             }


         }


        //------Inserrt into Database-------//
        public void InsertDB()
        {
            DBSetup();
            cmd = "Insert into Courses values('" + getCourseID() + "'," + "'" + getCourseName() + "'," 
                + "'" + getDescription() + "'," + getCreditHour() + ")";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Data Inserted");
                }
                else
                {
                    Console.WriteLine("Error: Inserting Data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection.Close();
            }
        } //End InsertDB()

        //------Update into Database-------//
        public void Upddate()
        {
            DBSetup();
            cmd = "Update Courses set CourseName ='" + getCourseName() + "',"
                + "Description ='" + getDescription() + "',"
                + " CreditHours = " + getCreditHour()+ " "
               + "where CourseID = '" + getCourseID() +"'";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Data Updated");
                }
                else
                {
                    Console.WriteLine("Error: Updating Data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection.Close();
            }
        } //End InsertDB()


        //Deleting DadaBase Method
        public void DeleteDB()
        {
            DBSetup();
            cmd = "Delete from Courses where CourseID = '"+ getCourseID() +"'";

            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Data Deleted");
                }
                else
                {
                    Console.WriteLine("Error: Deleting Data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection.Close();
            }
        }//End of Delete()
    }

    }

