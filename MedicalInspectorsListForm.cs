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
    public partial class MedicalInspectorsListForm : Form
    {
        int id;

        private void InspectorChoose()
        {
            string dbData = Program.Data.value;
            string query = $"SELECT * FROM MedicalInspectors ORDER BY InspectorID OFFSET @id ROWS FETCH NEXT 1 ROWS ONLY";


            using (SqlConnection conn = new SqlConnection(dbData))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id - 1);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Если есть данные
                        {
                            InspectorID.Text = reader["InspectorID"].ToString();
                            FirstName.Text = reader["FirstName"].ToString();
                            MiddleName.Text = reader["MiddleName"].ToString();
                            LastName.Text = reader["LastName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Данные не найдены");
                            NextBtn.Enabled = false;
                        }
                    }
                }
            }
        }

        public MedicalInspectorsListForm()
        {
            InitializeComponent();
        }

        private void MedicalInspectorsListForm_Load(object sender, EventArgs e)
        {
            id = 1;
            InspectorChoose();
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
                InspectorChoose();
                NextBtn.Enabled = true;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            id++;
            InspectorChoose();
            PreviousBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            id = 1;
            InspectorChoose();
            PreviousBtn.Enabled = true;
            NextBtn.Enabled = true;
        }

        private void SeachBtn_Click(object sender, EventArgs e)
        {
            string Surname = "";
            using (MedicalInspectorsListFindForm frm = new MedicalInspectorsListFindForm())
            {
                string dbData = Program.Data.value;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Surname = frm.Surname;
                }
                else
                {
                    MessageBox.Show("Поиск отменен!");
                    return;
                }
                string query = $"SELECT * FROM MedicalInspectors WHERE LastName = @Surname";
                using (SqlConnection conn = new SqlConnection(dbData))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Surname", Surname);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Если есть данные
                            {
                                InspectorID.Text = reader["InspectorID"].ToString();
                                FirstName.Text = reader["FirstName"].ToString();
                                MiddleName.Text = reader["MiddleName"].ToString();
                                LastName.Text = reader["LastName"].ToString();
                                id = Convert.ToInt32(InspectorID.Text);
                            }
                            else
                            {
                                MessageBox.Show("Данные не найдены");
                                NextBtn.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MedicalInspectorsWriteForm add = new MedicalInspectorsWriteForm();
            add.ShowDialog();
            InspectorChoose();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
