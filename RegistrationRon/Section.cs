/**************
 * Levi Llewellyn
 * Lab#2
 Section Class
 **********/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationRon
{
    class Section
    {//Declarations
        public int Crn;
        public string CourseID;
        public string Daytime;
        public string Room;
        public int InstructorID;
        public Schedule ss = new Schedule();


        public Section()
        {
            Crn = 0;
            CourseID = "";
            Daytime = "";
            Room = "";
            InstructorID = 0;
        }

        public Section(int c, string cid, string dt, string rm, int intd)
        {
            Crn = c;
            CourseID = cid;
            Daytime = dt;
            Room = rm;
            InstructorID = intd;
            
        }


        public int getCrn() { return Crn; }
        public void setCrn(int c){Crn = c;}

        public void setCourseID(string cid) { CourseID = cid; }
        public string getCourseID() { return CourseID; }

        public void setDaytime(string dt) { Daytime = dt; }
        public string getDaytime() { return Daytime; }

        public void setroom(string rm) { Room = rm; }
        public string getroom() { return Room; }

        public void setinstructorID(int intd) { InstructorID = intd; }
        public int getinstructorID() { return InstructorID; }


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
        public void SelectDB(int cr)
        {
            DBSetup();
            cmd = "Select * from Sections where CRN = " + cr;
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                Crn = cr;
                setCourseID(dr.GetValue(1) + "");
                setDaytime(dr.GetValue(2) + "");
                setroom(dr.GetValue(3) + "");
                setinstructorID(Int32.Parse(dr.GetValue(4) + ""));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection.Close();
            }
            //SelectDBi();
        }
        // end SelectDB

        //----Select Database Connection-----//
        public void SelectDBi()
        {
            DBSetup();
            cmd = "Select * from Sections";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                setCrn(Int32.Parse(dr.GetValue(0) + ""));
                setCourseID(dr.GetValue(1) + "");
                setDaytime(dr.GetValue(2) + "");
                setroom(dr.GetValue(3) + "");
               // InstructorID = id;
                setinstructorID(Int32.Parse(dr.GetValue(4) + ""));
                
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
        // end SelectDB


        //------Inserrt into Database-------//
        public void InsertDB()
        {
            DBSetup();
            cmd = "Insert into Sections values(" + getCrn() + "," + "'" + getCourseID() + "',"
                + "'" + getDaytime() + "'," + "'" + getroom() + "'," + getinstructorID() + ")";
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
            cmd = "Update Sections set CRN ='" + getCrn() + "',"
                + "CourseID ='" + getCourseID() + "',"+ "TimeDays ='" + getDaytime() + "',"
                + "RoomNo ='" + getroom() + "',"
                + "Instructor =" + getinstructorID() + " "
               + "where CRN = " + getCrn();

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
            cmd = "Delete from Sections where CRN = " + getCrn();

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

        //-----------Display Method-----------//
        public void display()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("crn = " + getCrn());
            Console.WriteLine("Course ID = " + getCourseID());
            Console.WriteLine("Day Time = " + getDaytime());
            Console.WriteLine("Room = " + getroom());
            Console.WriteLine("Instructor ID = " + getinstructorID());
            Console.WriteLine("---------------------");
          
        }

    }
}
