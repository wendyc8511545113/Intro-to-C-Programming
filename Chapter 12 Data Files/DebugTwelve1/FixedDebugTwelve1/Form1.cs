﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugTwelve1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            reddLabel.ForeColor = Color.Red;
            blueLabell.ForeColor = Color.BlueViolet;
            greenLabel.ForeColor = ColorGreen;
                    }
    }
}
