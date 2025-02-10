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
    public partial class MilitaryCommisariatListForm : Form
    {
        int id;

        private void CommissariatChoose()
        {
            string dbData = Program.Data.value;
            string query = $"SELECT * FROM MilitaryCommissariat ORDER BY CommissariatID OFFSET @id ROWS FETCH NEXT 1 ROWS ONLY";


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
                            FirstName.Text = reader["CommissionerFirstName"].ToString();
                            MiddleName.Text = reader["CommissionerMiddleName"].ToString();
                            LastName.Text = reader["CommissionerLastName"].ToString();
                            Street.Text = $"Ул. {reader["AddressStreet"].ToString()} Д. {reader["AddressBuilding"].ToString()}";
                            PhoneNumber.Text = reader["PhoneNumber"].ToString();
                            CommissariatNumber.Text = reader["CommissariatID"].ToString();

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
                            MessageBox.Show("Данные не найдены");
                            NextBtn.Enabled = false;
                        }
                    }
                }
            }
        }

        public MilitaryCommisariatListForm()
        {
            InitializeComponent();
        }

        private void MilitaryCommisariatListForm_Load(object sender, EventArgs e)
        {
            id = 1;
            CommissariatChoose();
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
                CommissariatChoose();
                NextBtn.Enabled = true;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            id++;
            CommissariatChoose();
            PreviousBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            id = 1;
            CommissariatChoose();
            PreviousBtn.Enabled = true;
            NextBtn.Enabled = true;
        }

        private void SeachBtn_Click(object sender, EventArgs e)
        {
            string Surname = "";
            using (ConscriptsListFindForm frm = new ConscriptsListFindForm())
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
                string query = $"SELECT * FROM MilitaryCommissariat WHERE CommissionerLastName = @Surname";
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
                                FirstName.Text = reader["CommissionerFirstName"].ToString();
                                MiddleName.Text = reader["CommissionerMiddleName"].ToString();
                                LastName.Text = reader["CommissionerLastName"].ToString();
                                Street.Text = $"Ул. {reader["AddressStreet"].ToString()} Д. {reader["AddressBuilding"].ToString()}";
                                PhoneNumber.Text = reader["PhoneNumber"].ToString();
                                CommissariatNumber.Text = reader["CommissariatID"].ToString();
                                id = Convert.ToInt32(CommissariatNumber.Text);


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
            MilitaryCommissariatWriteForm add = new MilitaryCommissariatWriteForm();
            add.ShowDialog();
            CommissariatChoose();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
