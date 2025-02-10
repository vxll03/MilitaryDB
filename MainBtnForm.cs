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
    public partial class MainBtnForm : Form
    {
        public MainBtnForm()
        {
            InitializeComponent();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConscriptListBtn_Click(object sender, EventArgs e)
        {
            ConscriptsListForm frm = new ConscriptsListForm();
            frm.ShowDialog();
        }

        private void ConscriptByNumberBtn_Click(object sender, EventArgs e)
        {
            ConscpritptsByNumberForm frm = new ConscpritptsByNumberForm();
            frm.ShowDialog();
        }

        private void MilitaryCommissariatListBtn_Click(object sender, EventArgs e)
        {
            MilitaryCommisariatListForm frm = new MilitaryCommisariatListForm();
            frm.ShowDialog();
        }

        private void MedicalCheckBtn_Click(object sender, EventArgs e)
        {
            MedicalExaminationsListForm frm = new MedicalExaminationsListForm();
            frm.ShowDialog();
        }

        private void MedicalWorkersBtn_Click(object sender, EventArgs e)
        {
            MedicalInspectorsListForm frm = new MedicalInspectorsListForm();
            frm.ShowDialog();
        }

        private void StatisticsBtn_Click(object sender, EventArgs e)
        {
            StatisticsForm frm = new StatisticsForm();
            frm.ShowDialog();
        }

        private void AdminPanel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
