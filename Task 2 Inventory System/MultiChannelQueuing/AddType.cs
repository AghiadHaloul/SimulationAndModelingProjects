﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Simulation
{
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }

        private void AddType_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            InventorySystemTask.Program.mForm.dayTypeDataGridView.Rows.Add(new string[] { nameTextBox.Text, probTextBox.Text });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
