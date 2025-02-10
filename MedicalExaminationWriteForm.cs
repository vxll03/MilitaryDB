using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military
{
    public partial class MedicalExaminationWriteForm : Form
    {
        public MedicalExaminationWriteForm()
        {
            InitializeComponent();
        }

        private void CommitBtn_Click(object sender, EventArgs e)
        {
            // Строка подключения к БД, предположим, что она хранится в Program.Data.value
            string dbData = Program.Data.value;

            // Параметризованный запрос для вставки новой записи в таблицу Conscripts
            string query =
                @"INSERT INTO MedicalExaminations 
                (ExaminationDate, InspectorID, FitnessCategoryID, ConscriptID, DefermentDate)
                VALUES 
                (@ExaminationDate, @InspectorID, @FitnessCategoryID, @ConscriptID, @DefermentDate)";

            using (SqlConnection connection = new SqlConnection(dbData))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Здесь можно получить данные из элементов управления, а пока задаём тестовые значения
                        command.Parameters.AddWithValue("@ExaminationDate", ExaminationDate.Text);
                        command.Parameters.AddWithValue("@InspectorID", InspectorID.Text);
                        command.Parameters.AddWithValue("@FitnessCategoryID", FitnessCategory.Text);
                        command.Parameters.AddWithValue("@ConscriptID", ConscriptID.Text);
                        command.Parameters.AddWithValue("@DefermentDate", DifermentDate.Text);
                        

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
