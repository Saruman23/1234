using pr1;
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
    public partial class Addworker : Form
    {
        private SqlConnection sql;

        public Addworker()
        {
            // Инициализация подключения к базе данных
            sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Учеба\3 курс\проги\pr1\Database1.mdf"";Integrated Security=True");
            InitializeComponent();
        }

        // Изменено: Добавлен метод для заполнения выпадающего списка профессий
        private void FillComboBox()
        {
            // Очистка списка перед заполнением
            comboBox1.Items.Clear();
            // Выборка данных из таблицы профессий
            string query = "SELECT ФИО FROM [Преподаватели]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sql);
            DataTable dt = new DataTable();
            // Заполнение таблицы данными из запроса
            dataAdapter.Fill(dt);
            // Добавление элементов в список
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            // Вызов метода для заполнения выпадающего списка при открытии списка
            FillComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Переменная для хранения id нового работника
            int id = 0;
            // Запрос для выборки данных из таблицы работников
            string query = "SELECT * FROM [Студенты]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sql);
            DataTable dt = new DataTable();
            // Открытие подключения к базе данных
            sql.Open();
            // Заполнение таблицы данными из запроса
            dataAdapter.Fill(dt);
            // Поиск максимального id среди существующих работников
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (id < Convert.ToInt32(dt.Rows[i][0].ToString()))
                    id = Convert.ToInt32(dt.Rows[i][0].ToString());
            }
            // Очистка таблицы и ее столбцов
            dt.Clear();
            dt.Columns.Clear();
            try
            {
                // Формирование запроса на добавление нового работника с полученным id и введенными данными
                query = "INSERT INTO [Студенты] VALUES (N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + comboBox1.Text + "');";
                // Выполнение запроса
                dataAdapter.SelectCommand = new SqlCommand(query, sql);
                dataAdapter.Fill(dt);
                // Закрытие подключения к базе данных
                sql.Close();
            }
            catch (Exception ex)
            {
                // Обработка возможных ошибок при выполнении запроса
                MessageBox.Show("Используйте только числовые значения для указания возраста. Не используйте более 50 символов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Закрытие формы добавления работника
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Addworker_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
