using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationRon
{
    class Instructor : Person
    {
        int iid;
        string officeNum;

        public Instructor()
        {
            int iid = 0;
            string officeNum = "";
        }

        public Instructor(int ii, string fn, string ln, Address a, string em, string off) : base(fn, ln, a, em)
        {
            iid = ii;
            officeNum = off;
        }

        public void setiid(int i) { iid = i; }
        public int getiid() { return iid; }

        public void setofficeNum(string off) { officeNum = off; }
        public string getofficeNum() { return officeNum; }



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
            cmd = "Select * from Instructors where ID = " + id + "";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            try
            {
                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                dr.Read();
                iid = id;
                setfname(dr.GetValue(1) + "");
                setlname(dr.GetValue(2) + "");
                base.a1.setstreet(dr.GetValue(3) + "");
                base.a1.setcity(dr.GetValue(4) + "");
                base.a1.setstate(dr.GetValue(5) + "");
                base.a1.setzip(double.Parse(dr.GetValue(6) + ""));
                setofficeNum(dr.GetValue(7) + "");
                setemail(dr.GetValue(8) + "");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                OleDbConnection.Close();
            }
            GetList();
        }
        // end SelectDB

        // getting schedule list instructor
        public void GetList()     {

            cmd = "Select CRN from Sections where Instructor = " + iid + "";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection;
            Console.WriteLine(cmd);
            int CRN = 0;
            Section s1 = new Section();
            try
            {

                OleDbConnection.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                while (dr.Read())
                {
                    CRN = Int32.Parse(dr.GetValue(0) + "");
                    s1 = new Section();
                    s1.SelectDB(CRN);
                    ss.add(s1);
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


        //------Insert Database method-------//
        public void InsertDB()
        {
            DBSetup();

            cmd = "Insert into Instructors values(" + getiid() + "," + "'" + getfname() + "'," + "'" + getlname()
                + "'," + "'" + base.a1.getstreet() + "'," + "'" + base.a1.getcity()
                + "'," + "'" + base.a1.getstate() + "'," + "'" + base.a1.getzip()
                + "'," + "'" + getofficeNum() + "'," + "'" + getemail() + "')";
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
            cmd = "Update Instructors set FirstName ='" + getfname() + "',"
                + "LastName ='" + getlname() + "',"
                + "Street = '" + base.a1.getstreet() + "',"
                + "City = '" + base.a1.getcity() + "',"
                + "State = '" + base.a1.getstate() + "',"
                + "Zip = " + base.a1.getzip() + ","
                + " Office ='" + getofficeNum() + "',"
                + "Email ='" + getemail() + "' "
               + "where ID = " + getiid();

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
            cmd = "Delete from Instructors where ID = " + getiid();

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
            Console.WriteLine("Instructor ID = " + getiid());
            Console.WriteLine("Office Number = " + getofficeNum());
            base.display();
        }
    }
}
