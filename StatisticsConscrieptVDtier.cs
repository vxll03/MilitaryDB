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
    public partial class StatisticsConscrieptVDtier : Form
    {
        public StatisticsConscrieptVDtier()
        {
            InitializeComponent();
        }

        private void StatisticsConscrieptVDtier_Load(object sender, EventArgs e)
        {
            string dbData = Program.Data.value;
            string query = @"
            SELECT fc.FitnessCategoryName AS 'Вид годности',
                   c.ConscriptID AS 'Номер призывника',
                   c.LastName AS 'Фамилия',
                   c.FirstName AS 'Имя',
                   c.MiddleName AS 'Отчество',
                   c.BirthDate AS 'Дата рождения'
            FROM Conscripts c
            JOIN MedicalExaminations me ON c.ConscriptID = me.ConscriptID
            JOIN FitnessCategories fc ON me.FitnessCategoryID = fc.FitnessCategoryID
            WHERE me.FitnessCategoryID IN (4, 5, 6);";

            using (SqlConnection connection = new SqlConnection(dbData))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            TableGridView.DataSource = dataTable;



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
