using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationRon
{
    class Schedule
    {
        Section[] sec = new Section[10];
        int count;

        public void addSection(Section s)
        {
            sec[count] = s;
            count++;
        }

        public void display()
        {
            Console.WriteLine("===========================");
            for (int i=0; i<count; i++)
            {
                sec[i].display();
                Console.WriteLine("-------------------------");
            }
        }

    }
}
