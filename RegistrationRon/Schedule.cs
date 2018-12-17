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
        //public Course[] arc = new Course[25];


        public void Section()
        {
            
        }

        public void add(Section s)
        {
            sec[count] = s;
            count++;
        }

        public void delsec(Section s)
        {
            for (int i = 0; i < sec.Length; i++) {
                if (s.getCrn() == sec[i].getCrn())
                {
                    sec[count] = sec[count - 1];
                   
                }
            }
            count--;
        }
        public void display()
        {
            for (int i=0; i<count; i++)
            {
                sec[i].display();
            }
        }
       // public void displayc()
        //{
          //  for (int i = 0; i < count; i++)
            //{
              //  arc[i].display();
            //}
        //}

      
      /*  public void addc(Course c)
        {
            arc[count] = c;
            count++;
        }*/
    }
}
