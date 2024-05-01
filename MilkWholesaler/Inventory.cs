﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkWholesaler
{
    public partial class Inventory : Form
    {
        private Form mainForm;

        public Inventory(Form main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void button_return_Click(object sender, EventArgs e)
        {

            this.Close();
            mainForm.Show();
        }
    }
}