﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortApp
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            dataGridViewTimes.Rows.Add("", 44, 55, 11, 33);
        }
        private void checkBoxRandom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGenArr_Click(object sender, EventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

        }
    }
}
