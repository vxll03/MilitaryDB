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
    public partial class ConscriptsByNumberFindForm : Form
    {
        public int id {  get; set; }

        public ConscriptsByNumberFindForm()
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

        private void ConscriptFindTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
