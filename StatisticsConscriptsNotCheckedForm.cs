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

namespace Military
{
    public partial class StatisticsConscriptsNotCheckedForm : Form
    {
        public StatisticsConscriptsNotCheckedForm()
        {
            InitializeComponent();
        }

        private void StatisticsConscriptsNotCheckedForm_Load(object sender, EventArgs e)
        {
            string dbData = Program.Data.value;
            // Запрос для получения списка призывников, не явившихся
            string query1 = @"
                SELECT c.CommissariatID AS 'Номер комиссариата',
                       c.ConscriptID AS 'Номер призывника',
                       c.LastName AS 'Фамилия',
                       c.FirstName AS 'Имя',
                       c.MiddleName AS 'Отчество',
                       c.PhoneNumber AS 'Номер телефона',
                       c.SummonsNumber AS 'Номер повестки'
                FROM Conscripts c
                JOIN MedicalExaminations m ON c.ConscriptID = m.ConscriptID
                WHERE m.FitnessCategoryID = 1;";

            // Запрос для получения количества не явившихся по каждому военкомату
            string query2 = @"
                SELECT c.CommissariatID AS 'Номер военкомата',
                       COUNT(c.ConscriptID) AS 'Количество не явившихся'
                FROM Conscripts c
                JOIN MedicalExaminations m ON c.ConscriptID = m.ConscriptID
                WHERE m.FitnessCategoryID = 1
                GROUP BY c.CommissariatID;";

            using (SqlConnection connection = new SqlConnection(dbData))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query1, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            TableGridView.DataSource = dataTable;
                        }
                    }

                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            TableGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex}");
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
