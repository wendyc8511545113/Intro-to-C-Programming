﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            buttonInfoLabel.Text = "You clicked a letter button";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonInfoLabel.Text = "You clicked a number button";
        }
    }
}
