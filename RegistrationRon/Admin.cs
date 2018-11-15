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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentControl sc = new StudentControl();
            sc.Show();
            this.Hide();
        }

        private void Instructorlb_Click(object sender, EventArgs e)
        {
            InstructorControl ic = new InstructorControl();
            ic.Show();
            this.Hide();
        }

        private void Sectionlb_Click(object sender, EventArgs e)
        {
            SectionControl sn = new SectionControl();
            sn.Show();
            this.Hide();
        }

        private void Courselb_Click(object sender, EventArgs e)
        {
            CourseControl cc = new CourseControl();
            cc.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loginform lg = new Loginform();
            this.Hide();
            lg.Show();
        }
    }
}
