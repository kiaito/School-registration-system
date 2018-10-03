/**************
 * Levi Llewellyn
 * Lab#2
 Address Class
 **********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationRon
{
    class Address
    {
        public string street;
        public string city;
        public string state;
        public double zip;

        public Address()
        {
            street = "";
            city = "";
            state = "";
            zip = 0;
        }
        public Address(string st, string cy, string ste, double zp)
        {
            street = st;
            city = cy;
            state = ste;
            zip = zp;
        }

        public void setstreet(string st) { street = st; }
        public string getstreet() { return street; }

        public void setcity(string cy) { city = cy; }
        public string getcity() { return city; }

        public void setstate(string ste) { state = ste; }
        public string getstate() { return state; }

        public void setzip(double zp) { zip = zp; }
        public double getzip() { return zip; }

        public void display()
        {
            Console.WriteLine("Street = " + getstreet());
            Console.WriteLine("city = " + getcity());
            Console.WriteLine("state = " + getstate());
            Console.WriteLine("zip = " + getzip());
        }
    }
}

