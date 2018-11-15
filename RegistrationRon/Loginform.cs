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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }
        //Declarations
        int userid = 0;
        string password = "";
        string stud = "student";
        string ad = "admin";
        Student ww;
        Instructor in1;

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void Passwordlb_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            userid = Int32.Parse(Usertb.Text);

            if (Pwtb.Text.Equals(stud)){
                //Forward control to studentdisplay form
                ww = new Student();
                ww.SelectDB(userid);
                StudentDisplay sd = new StudentDisplay();  
                this.Hide();
                sd.Show();  
            }
            else if (Pwtb.Text.Equals(ad))
            {//Forward control to admin panel
                Admin add = new Admin();
                this.Hide();
                add.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid User ID or Password");
            }
        }

        private void mainlabelb_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Usertb.Text = "";
            Pwtb.Text = "";
        }
    }
}
