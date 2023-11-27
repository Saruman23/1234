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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pr1
{
    public partial class Search : Form
    {
        private SqlConnection sql;
        public Search()
        {
            sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Учеба\3 курс\проги\pr1\Database1.mdf"";Integrated Security=True");
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string query;
            DataTable dt2 = new DataTable();
            query = "SELECT DISTINCT ФИО FROM [Студенты]";
            dataAdapter.SelectCommand = new SqlCommand(query, sql);
            dataAdapter.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt2.Rows[i][0].ToString());
            }
        }
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string query;
            DataTable dt2 = new DataTable();
            query = "SELECT DISTINCT Группа FROM [Студенты]";
            dataAdapter.SelectCommand = new SqlCommand(query, sql);
            dataAdapter.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt2.Rows[i][0].ToString());
            }
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string query;
            DataTable dt2 = new DataTable();
            query = "SELECT DISTINCT Преподаватель FROM [Студенты]";
            dataAdapter.SelectCommand = new SqlCommand(query, sql);
            dataAdapter.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                comboBox3.Items.Add(dt2.Rows[i][0].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool p=false;
            string query = "SELECT ФИО, Преподаватель FROM Студенты ";
            if (comboBox1.SelectedIndex != -1 || comboBox2.SelectedIndex != -1 || comboBox3.SelectedIndex != -1) query += "WHERE";
            if (comboBox1.SelectedIndex != -1) { query += " ФИО = '" + comboBox1.SelectedItem.ToString() + "'"; p = true; }
            if (comboBox2.SelectedIndex != -1) { if (p == true) query += " AND"; query += " Группа = N'" + comboBox2.SelectedItem.ToString() + "'"; }
            if (comboBox3.SelectedIndex != -1) { if (p == true) query += " AND"; query += " Преподаватель = N'" + comboBox3.SelectedItem.ToString() + "'"; }
            listBox1.Items.Clear();

                    sql.Open();
                    using (SqlCommand command = new SqlCommand(query, sql))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            string name = reader.GetString(0);
                            string profession = reader.GetString(1); ;
                                listBox1.Items.Add(name +" - "+ profession);
                            }
                        }
                    }
                sql.Close();
            
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

