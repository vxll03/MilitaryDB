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
using System.Windows.Forms.VisualStyles;

namespace Military
{
    public partial class MainForm : Form
    {
        string action;

        private void LoadData(string query)
        {
            string dbData = Program.Data.value;

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

                            if (dataTable.Columns.Contains("photo"))
                            {
                                DataColumn imageColumn = new DataColumn("Image", typeof(Image));
                                dataTable.Columns.Add(imageColumn);

                                foreach (DataRow row in dataTable.Rows)
                                {
                                    if (row["photo"] != DBNull.Value)
                                    {
                                        byte[] imageData = (byte[])row["photo"];

                                        try
                                        {
                                            using (MemoryStream memoryStream = new MemoryStream(imageData))
                                            {
                                                row["image"] = Image.FromStream(memoryStream);
                                            }
                                        }
                                        catch (ArgumentException ex)
                                        {
                                            row["image"] = null;
                                        }
                                    }
                                    else
                                    {
                                        row["image"] = null;
                                    }
                                }
                            }

                            TableGridView.DataSource = dataTable;

                            if (TableGridView.Columns.Contains("Image"))
                            {
                                var imageCol = TableGridView.Columns["Image"] as DataGridViewImageColumn;
                                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            }

                            if (TableGridView.Columns.Contains("photo"))
                            {
                                TableGridView.Columns["photo"].Visible = false;
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

        private void ChangeData(string action, string table, string id, Form form)
        {
            string query = "";
            if (action == null)
            {
                MessageBox.Show("Выберите действие!");
            }
            else
            {
                switch (action)
                {
                    case "Чтение":
                        query = $"SELECT * FROM {table}";
                        break;

                    case "Запись":
                        form.ShowDialog();
                        query = $"SELECT * FROM {table}";
                        break;

                    case "Удаление":
                        using (RowDeleteForm inputForm = new RowDeleteForm())
                        {
                            if (inputForm.ShowDialog() == DialogResult.OK)
                            {
                                int input = int.Parse(inputForm.InputValue);
                                query = $"DELETE FROM {table} WHERE {id} = {input}";
                            }
                            else
                            {
                                MessageBox.Show("Удаление было отменено");
                                return;
                            }
                        }
                        break;
                }
                LoadData(query);
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TableGridView.SizeChanged += (s, ev) => AdjustRowHeights();
            this.TableGridView.RowsAdded += (s, ev) => AdjustRowHeights();
            this.TableGridView.RowsRemoved += (s, ev) => AdjustRowHeights();
            this.TableGridView.DataBindingComplete += (s, ev) => AdjustRowHeights();
            AdjustRowHeights();
        }

        private void ChangeActionBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            action = btn.Text;
            //MessageBox.Show(action);

            Button[] buttons = { ReadBtn, WriteBtn, DeleteBtn };
            foreach (Button button in buttons)
            {
                if (button == sender)
                {
                    button.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
                    button.BackColor = Color.FromArgb(136, 121, 82);
                }
                else
                {
                    button.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
                    button.BackColor = Color.FromArgb(68, 60, 41);
                }
            }
        }

        private void ConscriptsBtn_Click(object sender, EventArgs e)
        {
            ChangeData(action, "Conscripts", "ConscriptID", new ConscriptsWriteForm());
        }

        private void ComissariatBtn_Click(object sender, EventArgs e)
        {
            ChangeData(action, "MilitaryCommissariat", "CommissariatID", new MilitaryCommissariatWriteForm());
        }

        private void MedInspectorsBtn_Click(object sender, EventArgs e)
        {
            ChangeData(action, "MedicalInspectors", "InspectorID", new MedicalInspectorsWriteForm());
        }

        private void MedicalExaminationBtn_Click(object sender, EventArgs e)
        {
            ChangeData(action, "MedicalExaminations", "ExaminationID", new MedicalExaminationWriteForm());
        }

        private void EducationTypeBtn_Click(object sender, EventArgs e)
        {
            ChangeData(action, "EducationType", "EducationTypeID", new EducationTypeWriteForm());
        }

        private void MilitaryAssignmentsBtn_Click(object sender, EventArgs e)
        {
            ChangeData(action, "MilitaryAssignments", "AssgnmentID", new MilitaryAssignmentWriteForm());
        }

        private void FitnessCategoriesBtn_Click(object sender, EventArgs e)
        {
            ChangeData(action, "FitnessCategories", "FitnessCategoryID", new FitnessCategoriesWriteForm());
        }

        private void TroopTypesBtn_Click(object sender, EventArgs e)
        {
            ChangeData(action, "TroopTypes", "TroopTypeID", new TroopTypesWriteForm());
        }
    }
}
