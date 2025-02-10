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
using System.Xml.Linq;

namespace Military
{
    public partial class ConscriptsListForm : Form
    {
        int id;

        private void ConscriptChoose()
        {
            string dbData = Program.Data.value;
            string query = $"SELECT * FROM Conscripts ORDER BY ConscriptID OFFSET @id ROWS FETCH NEXT 1 ROWS ONLY";


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
                            MessageBox.Show("Данные не найдены");
                            NextBtn.Enabled = false;
                        }
                    }
                }
            }
        }

        public ConscriptsListForm()
        {
            InitializeComponent();
        }

        private void ConscriptsListForm_Load(object sender, EventArgs e)
        {
            id = 1;
            ConscriptChoose();
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
                ConscriptChoose();
                NextBtn.Enabled = true;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            id++;
            ConscriptChoose();
            PreviousBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            id = 1;
            ConscriptChoose();
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
            string query = $"SELECT * FROM Conscripts WHERE LastName = @Surname";
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
                            FirstName.Text = reader["FirstName"].ToString();
                            MiddleName.Text = reader["MiddleName"].ToString();
                            LastName.Text = reader["LastName"].ToString();
                            Street.Text = $"Ул. {reader["AddressStreet"].ToString()} Д. {reader["AddressBuilding"].ToString()}";
                            PhoneNumber.Text = reader["PhoneNumber"].ToString();
                            BirthDate.Text = reader["BirthDate"].ToString();
                            EducationType.Text = reader["EducationTypeID"].ToString();
                            ConscriptNumber.Text = reader["ConscriptID"].ToString();
                            SummonNumber.Text = reader["SummonsNumber"].ToString();
                            CommissariatID.Text = reader["CommissariatID"].ToString();
                            id = Convert.ToInt32(ConscriptNumber.Text);

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

        private void EducationType_TextChanged(object sender, EventArgs e)
        {

            string id = EducationType.Text;
            string dbData = Program.Data.value;
            string query = $"SELECT * FROM EducationType WHERE EducationTypeID = @id";

            using (SqlConnection conn = new SqlConnection(dbData))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Проверяем, есть ли строка в результате запроса
                        {
                            EducationType.TextChanged -= EducationType_TextChanged; // Отключаем обработчик, чтобы избежать зацикливания
                            EducationType.Text = reader["EducationTypeName"].ToString();
                            EducationType.TextChanged += EducationType_TextChanged; // Включаем обратно
                        }
                    }
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ConscriptsWriteForm add = new ConscriptsWriteForm();
            add.ShowDialog();
            ConscriptChoose();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
