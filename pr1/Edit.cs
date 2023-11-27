using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    public partial class Edit : Form
    {
        private SqlConnection sql;
        public Edit()
        {
            sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Учеба\3 курс\проги\pr1\Database1.mdf"";Integrated Security=True");
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sql.Open();
            if (tabControl1.SelectedIndex == 0)
            {
                query = "SELECT * FROM [Студенты]";
                dataAdapter.SelectCommand = new SqlCommand(query, sql);
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                query = "SELECT * FROM [Преподаватели]";
                dataAdapter.SelectCommand = new SqlCommand(query, sql);
                dataAdapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            sql.Close();
        }

        //Add

        private void Addbtn1_Click(object sender, EventArgs e)
        {
            var AddForm = new AddStudent();
            AddForm.Show();
        }

        private void Addbtn2_Click(object sender, EventArgs e)
        {
            var AddForm = new Addworker2();
            AddForm.Show();
        }

        //Delete

        private void Deletebtn1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                DialogResult dia = MessageBox.Show("Вы точно хотите удалить студента с id: " + dataGridView1.CurrentRow.Cells[0].Value.ToString(), "ВНИМАНИЕ!", MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {
                    string query;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    sql.Open();
                    query = "DELETE FROM студенты WHERE IDстуденты=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ";";
                    dataAdapter.SelectCommand = new SqlCommand(query, sql);
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sql.Close();
                    tabControl1_SelectedIndexChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Удалять нечего!");
            }
        }

        private void Deletebtn2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                DialogResult dia = MessageBox.Show("Вы точно хотите удалить преподавателя с id: " + dataGridView2.CurrentRow.Cells[0].Value.ToString(), "ВНИМАНИЕ!", MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {
                    string query;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    sql.Open();
                    query = "DELETE FROM Преподаватели WHERE IDПреподаватели=" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + ";";
                    dataAdapter.SelectCommand = new SqlCommand(query, sql);
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sql.Close();
                    tabControl1_SelectedIndexChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Удалять нечего!");
            }
        }

        //Update

        private void Updatebtn1_Click(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void Updatebtn2_Click(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
