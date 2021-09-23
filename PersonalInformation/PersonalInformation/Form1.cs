using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string FName = fname.Text;
            string LName = lname.Text;
            var PNo = pno.Text;
            string School = school.Text;
            string Major = major.Text;

            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;

            textBox1.Text = Major;
            textBox2.Text = School;
            textBox3.Text = PNo;
            textBox4.Text = LName;
            textBox5.Text = FName;
            fname.Text = "";
            lname.Text = "";
            pno.Text = "";
            school.Text = "";
            major.Text = "";
        }
    }
}
