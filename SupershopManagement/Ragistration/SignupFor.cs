﻿using System;
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
    public partial class SignupFor : Form
    {
        public SignupFor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                this.Hide();
                CustomerRegistration customerRegistration = new CustomerRegistration();
                customerRegistration.Show();
            }
            else
            {
                this.Hide();
                EmployeRegistration employeRegistration = new EmployeRegistration();
                employeRegistration.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void SignupFor_Load(object sender, EventArgs e)
        {

        }
    }
}
