﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_v2
{
    public partial class Form1 : Form
    {
        NWOrdersDataContext dbContext = new NWOrdersDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orderDataGridView.DataSource = dbContext.Orders;
        }

        private void orderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}