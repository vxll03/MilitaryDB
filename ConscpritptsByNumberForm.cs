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
    public partial class ConscpritptsByNumberForm : Form
    {
        public ConscpritptsByNumberForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConscpritptsByNumberForm_Load(object sender, EventArgs e)
        {
            using (ConscriptsByNumberFindForm frm = new ConscriptsByNumberFindForm())
            {
                string dbData = Program.Data.value;
                string query = $"SELECT * FROM Conscripts WHERE ConscriptID = @id";
                int id = 0;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    id = frm.id;
                }
                else
                {
                    MessageBox.Show("Поиск отменен!");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(dbData))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Если есть данные
                            {
                                FirstName.Text = reader["FirstName"].ToString();
                                MiddleName.Text = reader["MiddleName"].ToString();
                                LastName.Text = reader["LastName"].ToString();
                                Street.Text = $"Ул. {reader["AddressStreet"].ToString()} Д. {reader["AddressBuilding"].ToString()}";
                                PhoneNumber.Text = reader["PhoneNumber"].ToString();
                                BirthDate.Text = reader["BirthDate"].ToString();
                                ConscriptNumber.Text = reader["ConscriptID"].ToString();
                                SummonNumber.Text = reader["SummonsNumber"].ToString();
                                CommissariatID.Text = reader["CommissariatID"].ToString();
                                EducationType.Text = reader["EducationTypeID"].ToString();
                                CriminalRecordCheck.Checked = (bool)reader["CriminalRecord"];

                                if (!(reader["Photo"] is DBNull)) // Проверяем, есть ли фото
                                {
                                    byte[] imageData = (byte[])reader["Photo"]; // Считываем бинарные данные
                                    using (MemoryStream ms = new MemoryStream(imageData)) // Создаём поток
                                    {
                                        PhotoBox.Image = Image.FromStream(ms); // Загружаем в PictureBox
                                    }
                                }
                                else
                                {
                                    PhotoBox.Image = null; // Если фото нет, очищаем PictureBox
                                }
                            }
                            else
                            {
                                MessageBox.Show("Данные не найдены, закрытие формы");
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}
