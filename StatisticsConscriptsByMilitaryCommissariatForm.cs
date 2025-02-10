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
    public partial class StatisticsConscriptsByMilitaryCommissariatForm : Form
    {
        public StatisticsConscriptsByMilitaryCommissariatForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatisticsConscriptsByMilitaryCommissariatForm_Load(object sender, EventArgs e)
        {
            int id;
            using (StatisticsConscriptByMilitaryCommissariatFindForm frm = new StatisticsConscriptByMilitaryCommissariatFindForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    id = frm.id;
                }
                else
                {
                    MessageBox.Show("Поиск отменен!");
                    return;
                }

                string dbData = Program.Data.value;
                string query = @"
                SELECT c.ConscriptID AS 'Номер призывника',
                       c.LastName AS 'Фамилия',
                       c.FirstName AS 'Имя',
                       c.MiddleName AS 'Отчество',
                       c.PhoneNumber AS 'Номер телефона',
                       c.BirthDate AS 'Дата рождения',
                       c.SummonsNumber AS 'Номер повестки'
                FROM Conscripts c
                WHERE c.CommissariatID = @CommissariatID;";

                using (SqlConnection connection = new SqlConnection(dbData))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CommissariatID", id);
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

            label2.Text += $"{id}";
        }
    }
}
