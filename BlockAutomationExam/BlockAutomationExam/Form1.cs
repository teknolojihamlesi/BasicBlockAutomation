﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockAutomationExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gelirler_Click(object sender, EventArgs e)
        {
            new Gelirler().Show();
        }

        private void giderler_Click(object sender, EventArgs e)
        {
            new Giderler().Show();
        }
    }
}
