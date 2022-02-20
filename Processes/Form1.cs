﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Processes
{
    public partial class Form1 : Form
    {
        public DataAcquisition presenter { get; set; }
        public DataGridView GetDataGridView() { return dataGridView1; }
        public DataGridView GetDataGridView2() { return dataGridView2; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //presenter.UpdateProcesses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Thread thread = new Thread(presenter.UpdateProcesses);
             thread.Start();*/
            presenter.UpdateProcesses();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           // presenter.UpdateThreads();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.UpdateThreads();
        }
    }
}