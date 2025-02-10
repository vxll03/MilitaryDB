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
    public partial class StatisticsConscriptByMilitaryCommissariatFindForm : Form
    {
        public int id {  get; set; }
        public StatisticsConscriptByMilitaryCommissariatFindForm()
        {
            InitializeComponent();
        }

        private void ConscriptFindBtn_Click(object sender, EventArgs e)
        {
            try
            {
                id = Int32.Parse(ConscriptFindTextBox.Text);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Введите числовое значение!");
            }
        }
    }
}
