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
    public partial class TroopTypesWriteForm : Form
    {
        public TroopTypesWriteForm()
        {
            InitializeComponent();
        }

        private void CommitBtn_Click(object sender, EventArgs e)
        {
            // Строка подключения к БД, предположим, что она хранится в Program.Data.value
            string dbData = Program.Data.value;

            // Параметризованный запрос для вставки новой записи в таблицу Conscripts
            string query =
                @"INSERT INTO TroopTypes 
                (TroopTypeName)
                VALUES 
                (@TroopTypeName)";

            using (SqlConnection connection = new SqlConnection(dbData))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Здесь можно получить данные из элементов управления, а пока задаём тестовые значения
                        command.Parameters.AddWithValue("@TroopTypeName", TroopType.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"Добавлено строк: {rowsAffected}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
            this.Close();
        }
    }
}
