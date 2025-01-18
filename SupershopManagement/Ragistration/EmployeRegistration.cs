using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupershopManagement.Ragistration
{
    public partial class EmployeRegistration : Form
    {
        public EmployeRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmployeRegistration_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            information_panel.Visible = false;
            contact_panel.Visible = true;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            contact_panel.Visible = false;
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            contact_panel.Visible = false;
            information_panel.Visible = true;

        }


        private void button6_Click_2(object sender, EventArgs e)
        {
            panel3.Visible = false;
            contact_panel.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
