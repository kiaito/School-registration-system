using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationRon
{
    class Schedule
    {
        public Section[] sec = new Section[10];
        public int count;
        public Course[] arc = new Course[15];


        public void Section()
        {
            
        }

        public void add(Section s)
        {
            sec[count] = s;
            count++;
        }

        public void display()
        {
            for (int i=0; i<count; i++)
            {
                sec[i].display();
            }
        }

        public void Course()
        {

        }
        public void addc(Course c)
        {
            arc[count] = c;
            count++;
        }
    }
}
