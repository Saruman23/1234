using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var SearchForm = new Search();
            SearchForm.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var EditForm = new Edit();
            EditForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ТеstBtn_Click(object sender, EventArgs e)
        {
            var TestForm = new Test();
            TestForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ResultsForm = new Results();
            ResultsForm.Show();
        }

        private void AutBtn_Click(object sender, EventArgs e)
        {
            var AuthorizationForm = new Authorization();
            AuthorizationForm.Show();
        }
    }
}
