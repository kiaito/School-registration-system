using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationRon
{
    class Student : Person
    {
        //--------properties--------//
        int sid;
        double gpa;

        //--------Constructors-------//
        public Student() : base()
        {
            sid = 0;
        }

        public Student(int i, string fn, string ln, Address a, string em, double g) : base(fn, ln, a, em)
        {
            sid = i;
            gpa = g;
        }
        //------getters ans setters--------//
        public void setsid(int i) { sid = i; }
        public int getsid() { return sid; }

        public void setgpa(double g) { gpa = g; }
        public double getgpa() { return gpa; }

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
        public void SelectDB(int id)
        {
            DBSetup();
            cmd = "Select * from Students where ID = " + id + "";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                sid = id;
                setfname(dr.GetValue(1) + "");
                setlname(dr.GetValue(2) + "");
                base.a1.setstreet(dr.GetValue(3) + "");
                base.a1.setcity(dr.GetValue(4) + "");
                base.a1.setstate(dr.GetValue(5) + "");
                base.a1.setzip(double.Parse(dr.GetValue(6) + ""));
                setemail(dr.GetValue(7) + "");
                setgpa(double.Parse(dr.GetValue(8) + ""));


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

            //------Insert Database method-------//
              public void InsertDB()
              {
                  DBSetup();

                  cmd = "Insert into Students values(" + getsid() + "," + "'" + getfname() + "'," + "'" + getlname()
                      + "'," + "'" + base.a1.getstreet() + "'," + "'" + base.a1.getcity()
                      + "'," + "'" + base.a1.getstate() + "'," + "'" + base.a1.getzip() + "'," + "'" + getemail()
                      + "'," + getgpa() + ")";
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
            cmd = "Update Students set  ID= " + getsid() + ","
                + "FirstName ='" + getfname() + "',"
                + "LastName ='" + getlname() + "',"
                + "Street = '" + base.a1.getstreet() + "',"
                + "City = '" + base.a1.getcity() + "',"
                + "State = '" + base.a1.getstate() + "',"
                + "Zip = " + base.a1.getzip() + ","
                + "Email ='" + getemail() + "',"
                + "GPA =" + getgpa() + " "
               
               + "where ID = " + getsid();

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
            cmd = "Delete from Students where ID = " + getsid();

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


        public void display()
        {
            Console.WriteLine("Student ID = " + getsid());
            base.display();
            Console.WriteLine("Gpa = " + getgpa());
        }
    }
}

