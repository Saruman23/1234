﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            var AddForm = new Addworker();
            AddForm.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            var AddForm = new Addworker2();
            AddForm.Show();
        }
    }
}
