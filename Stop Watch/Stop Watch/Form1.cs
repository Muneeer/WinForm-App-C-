using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stop_Watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timenow.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            var startTime = DateTime.Now;
            starttext.Text = startTime.ToLongTimeString();
        }

        private void endbtn_Click(object sender, EventArgs e)
        {
            if(starttext.Text!="")
            {
                var endTime = DateTime.Now;
                endtext.Text = endTime.ToLongTimeString();
                DateTime ed = Convert.ToDateTime(endtext.Text);
                DateTime sd = Convert.ToDateTime(starttext.Text);
                TimeSpan ts = ed.Subtract(sd);
                int totalseconds = Convert.ToInt32(ts.TotalSeconds);
                elapsedtime.Text = totalseconds.ToString()+" seconds";
            }
            else
            {
                MessageBox.Show("Start the time first!!");
            }
            
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
