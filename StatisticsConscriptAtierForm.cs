using System;
using System.Collections;
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
    public partial class StatisticsConscriptAtierForm : Form
    {
        public StatisticsConscriptAtierForm()
        {
            InitializeComponent();
        }

        private void StatisticsConscriptAtierForm_Load(object sender, EventArgs e)
        {
            string dbData = Program.Data.value;
            string query = @"
                        SELECT c.ConscriptID, c.LastName, c.FirstName, c.MiddleName, 
                               c.SummonsNumber, c.BirthDate
                        FROM Conscripts c
                        JOIN MedicalExaminations me ON c.ConscriptID = me.ConscriptID
                        WHERE me.FitnessCategoryID = 2;";

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

                            if (TableGridView.Columns.Count > 0)
                            {
                                TableGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                TableGridView.Columns["ConscriptID"].HeaderText = "№";
                                TableGridView.Columns["LastName"].HeaderText = "Фамилия";
                                TableGridView.Columns["FirstName"].HeaderText = "Имя";
                                TableGridView.Columns["MiddleName"].HeaderText = "Отчество";
                                TableGridView.Columns["SummonsNumber"].HeaderText = "Номер повестки";
                                TableGridView.Columns["BirthDate"].HeaderText = "Дата рождения";
                            }

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
