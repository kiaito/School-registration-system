using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationRon
{
    class Person
    {
        string fname;
        string lname;
        public Address a1 = new Address();
        public Schedule ss = new Schedule();
 
        string email;

        public Person()
        {
            fname = "";
            lname = "";
            
            email = "";
        }
        public Person(string fn, string ln, Address a, string em)
        {
            fname = fn;
            lname = ln;
            a1 = a;
            
            email = em;
        }

        public void setfname(string fn) { fname = fn; }
        public string getfname() { return fname; }

        public void setlname(string ln) { lname = ln; }
        public string getlname() { return lname; }

        public void setemail(string em) { email = em; }
        public string getemail() { return email; }

        public void setaddress(Address a) { a1 = a; }
        public Address getaddress() { return a1; }

        //public void setaddress(string add) { address = add; }
        //public string getaddress() { return address; }

        public void display()
        {
            Console.WriteLine("First name = " + getfname());
            Console.WriteLine("Last Name = " + getlname());
            Console.WriteLine("Email = " + getemail());
            a1.display();
            ss.display();
        }
    }
}
// use base to access address properties
