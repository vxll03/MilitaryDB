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
    public partial class StatisticsByCommissariatDiagramForm : Form
    {
        public StatisticsByCommissariatDiagramForm()
        {
            InitializeComponent();
        }

        private void StatisticsByCommissariatDiagramForm_Load(object sender, EventArgs e)
        {
            string dbData = Program.Data.value;
            string query = @"
                SELECT 
                    c.CommissariatID AS 'Номер военкомата',
                    COUNT(c.ConscriptID) AS 'Количество призывников'
                FROM 
                    Conscripts c
                GROUP BY 
                    c.CommissariatID";

            using (SqlConnection conn = new SqlConnection(dbData))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Очищаем Chart перед добавлением новых данных
                        educationChart.Series.Clear();

                        // Добавляем новую серию для данных
                        var series = educationChart.Series.Add("Количество человек");
                        series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Тип диаграммы: столбчатая

                        // Устанавливаем подписи по оси X и значения по оси Y
                        while (reader.Read())
                        {
                            string educationType = reader["Номер военкомата"].ToString();
                            int count = Convert.ToInt32(reader["Количество призывников"]);

                            // Добавляем точку на диаграмму
                            series.Points.AddXY(educationType, count);
                        }

                        educationChart.ChartAreas[0].AxisX.Title = "Номер военкомата";
                        educationChart.ChartAreas[0].AxisY.Title = "Количество призывников";
                        // Настройка цвета столбцов
                        foreach (var ser in educationChart.Series)
                        {
                            ser.Color = Color.FromArgb(68, 60, 41);
                            ser.BorderColor = Color.Black; // Цвет рамки
                            ser.BorderWidth = 1;
                        }
                    }

                    this.educationChart.ChartAreas[0].BackColor = Color.FromArgb(136, 121, 82);
                    this.educationChart.Legends[0].BackColor = Color.FromArgb(136, 121, 82);
                    this.educationChart.Legends[0].ForeColor = Color.White;
                    this.educationChart.ChartAreas[0].BackColor = Color.FromArgb(136, 121, 82);
                    this.educationChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
                    this.educationChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
                    this.educationChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                    this.educationChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                    this.educationChart.ChartAreas[0].AxisX.TitleForeColor = Color.White;
                    this.educationChart.ChartAreas[0].AxisY.TitleForeColor = Color.White;
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
