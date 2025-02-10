using System;
using System.Collections;
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
    public partial class ConscriptsWriteForm : Form
    {
        public ConscriptsWriteForm()
        {
            InitializeComponent();
        }

        private void CommitBtn_Click(object sender, EventArgs e)
        {
            // Строка подключения к БД, предположим, что она хранится в Program.Data.value
            string dbData = Program.Data.value;

            // Параметризованный запрос для вставки новой записи в таблицу Conscripts
            string query = 
                @"INSERT INTO Conscripts 
                (CommissariatID, LastName, FirstName, MiddleName, PhoneNumber, SummonsNumber, BirthDate, AddressStreet, AddressBuilding, EducationTypeID, CriminalRecord, Photo)
                VALUES 
                (@CommissariatID, @LastName, @FirstName, @MiddleName, @PhoneNumber, @SummonsNumber, @BirthDate, @AddressStreet, @AddressBuilding, @EducationTypeID, @CriminalRecord, @Photo)";

            using (SqlConnection connection = new SqlConnection(dbData))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Здесь можно получить данные из элементов управления, а пока задаём тестовые значения
                        command.Parameters.AddWithValue("@CommissariatID", CommissariatID.Text);
                        command.Parameters.AddWithValue("@LastName", LastName.Text);
                        command.Parameters.AddWithValue("@FirstName", FirstName.Text);
                        command.Parameters.AddWithValue("@MiddleName", MiddleName.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber.Text);
                        command.Parameters.AddWithValue("@SummonsNumber", SummonNumber.Text);
                        command.Parameters.AddWithValue("@BirthDate", DateTime.Parse(BirthDate.Text));
                        command.Parameters.AddWithValue("@AddressStreet", Street.Text);
                        command.Parameters.AddWithValue("@AddressBuilding", Building.Text);
                        command.Parameters.AddWithValue("@EducationTypeID", EducationID.Text);
                        command.Parameters.AddWithValue("@CriminalRecord", CriminalRecord.Checked);

                        byte[] photoBytes = GetPhotoBytes();
                        if (photoBytes != null)
                        {
                            command.Parameters.AddWithValue("@Photo", photoBytes);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Photo", DBNull.Value);
                        }

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

        private void ImageLoad_Click(object sender, EventArgs e)
        {
            // Создаём диалог для выбора файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Задаём начальную директорию (например, "Мои Изображения")
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                // Фильтр для выбора только файлов изображений
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Если пользователь выбрал файл и нажал ОК
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получаем путь к выбранному файлу
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        // Загружаем изображение из файла
                        Image image = Image.FromFile(filePath);
                        // Отображаем изображение в PictureBox (например, pictureBoxPhoto)
                        PhotoPictureBox.Image = image;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
                    }
                }
            }
        }

        private byte[] GetPhotoBytes()
        {
            if (PhotoPictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PhotoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            return null;
        }
    }
}
