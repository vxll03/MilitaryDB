using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConscriptByNumberBtn_Click(object sender, EventArgs e)
        {
            StatisticsConscriptAtierForm frm = new StatisticsConscriptAtierForm();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatisticsConscrieptVDtier frm = new StatisticsConscrieptVDtier();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StatisticsConscriptsByMilitaryCommissariatForm frm = new StatisticsConscriptsByMilitaryCommissariatForm();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StatisticsConscriptsNotCheckedForm frm = new StatisticsConscriptsNotCheckedForm();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StatisticsConscriptsByMedicalInspectorForm frm = new StatisticsConscriptsByMedicalInspectorForm();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StatisticsByEducationForm frm = new StatisticsByEducationForm();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StatisticsByFitnessCategoriesForm frm = new StatisticsByFitnessCategoriesForm();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatisticsByCommissariatDiagramForm frm = new StatisticsByCommissariatDiagramForm();
            frm.ShowDialog();
        }
    }
}
