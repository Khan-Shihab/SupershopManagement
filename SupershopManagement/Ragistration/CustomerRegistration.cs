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
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
         
        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            information_panel.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            information_panel.Visible = false;
            contact_panel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            contact_panel.Visible = false;
            panel3.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            contact_panel.Visible = false;
            information_panel.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
            contact_panel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
        }

        private void contact_panel_Paint(object sender, PaintEventArgs e)
        {//shihab gay
        }
    }
    
}
