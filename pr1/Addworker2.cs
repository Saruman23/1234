using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pr1
{
    public partial class Addworker2 : Form
    {
        private SqlConnection sql;

        public Addworker2()
        {
            sql = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Учеба\3 курс\проги\pr1\Database1.mdf"";Integrated Security=True");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            string query = "SELECT MAX(IDПреподаватели) FROM [Преподаватели]"; // Изменено: использование функции MAX для получения максимального Id

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(sql.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    id = command.ExecuteScalar() as int? ?? 0;
                    // Изменено: использование ExecuteScalar для получения значения максимального Id

                    // Изменено: использование параметризованного запроса для предотвращения SQL инъекций
                    query = "INSERT INTO [Преподаватели] VALUES (@ФИО, @Дисциплина)";
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@ФИО", textBox1.Text);
                    command.Parameters.AddWithValue("@Дисциплина", textBox2.Text);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Для значения оклада нужно использовать только числа. Не используйте более 50 символов.: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            this.Close();
        }

        private void Addworker2_Load(object sender, EventArgs e)
        {

        }
    }
}