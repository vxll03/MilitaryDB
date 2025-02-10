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
    public partial class MedicalExaminationsListForm : Form
    {
        int id;
        string conscript, category, inspector;

        private void ExaminationChoose()
        {
            string dbData = Program.Data.value;
            string examinationQuery = $"SELECT * FROM MedicalExaminations ORDER BY ExaminationID OFFSET @id ROWS FETCH NEXT 1 ROWS ONLY";
            string inspectorQuery = $"SELECT LastName, FirstName, MiddleName FROM MedicalInspectors WHERE InspectorID = @thisInspector";
            string conscriptQuery = $"SELECT LastName, FirstName, MiddleName FROM Conscripts WHERE ConscriptID = @thisConscript";
            string categoryQuery = $"SELECT FitnessCategoryName FROM FitnessCategories WHERE FitnessCategoryID = @thisCategory";

            using (SqlConnection conn = new SqlConnection(dbData))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(examinationQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id - 1);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Если есть данные
                        {
                            ExaminationDate.Text = reader["ExaminationDate"].ToString();
                            ExaminationID.Text = reader["ExaminationID"].ToString();
                            InspectorID.Text = reader["InspectorID"].ToString();
                            ConscriptID.Text = reader["ConscriptID"].ToString();
                            inspector = reader["InspectorID"].ToString();
                            conscript = reader["ConscriptID"].ToString();
                            category = reader["FitnessCategoryID"].ToString();
                            if (reader["DefermentDate"] == DBNull.Value)
                            {
                                DifermentDate.Text = "Нет";
                            }
                            else
                            {
                                DifermentDate.Text = reader["DefermentDate"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Данные не найдены");
                            NextBtn.Enabled = false;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand(inspectorQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@thisInspector", inspector);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            InspectorLastName.Text = reader["LastName"].ToString();
                            InspectorFirstName.Text = reader["FirstName"].ToString();
                            InspectorMiddleName.Text = reader["MiddleName"].ToString();
                        }
                    }
                }

                using (SqlCommand cmd = new SqlCommand(conscriptQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@thisConscript", conscript);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ConscriptLastName.Text = reader["LastName"].ToString();
                            ConscriptFirstName.Text = reader["FirstName"].ToString();
                            ConscriptMiddleName.Text = reader["MiddleName"].ToString();
                        }
                    }
                }

                using (SqlCommand cmd = new SqlCommand(categoryQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@thisCategory", category);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            FitnessCategory.Text = reader["FitnessCategoryName"].ToString();
                        }
                    }
                }
            }
        }

        public MedicalExaminationsListForm()
        {
            InitializeComponent();
        }

        private void MedicalExaminationsListForm_Load(object sender, EventArgs e)
        {
            id = 1;
            ExaminationChoose();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                MessageBox.Show("Вы в начале списка!");
                PreviousBtn.Enabled = false;
            }
            else
            {
                id--;
                ExaminationChoose();
                NextBtn.Enabled = true;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            id++;
            ExaminationChoose();
            PreviousBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            id = 1;
            ExaminationChoose();
            PreviousBtn.Enabled = true;
            NextBtn.Enabled = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MedicalExaminationWriteForm add = new MedicalExaminationWriteForm();
            add.ShowDialog();
            ExaminationChoose();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
