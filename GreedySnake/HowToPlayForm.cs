﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreedySnake
{
    public partial class HowToPlayForm : Form
    {
        public HowToPlayForm()
        {
            InitializeComponent();
        }

        void Okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
