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
    public partial class MilitaryCommissariatListFindForm : Form
    {
        public string Surname { get; set; }

        public MilitaryCommissariatListFindForm()
        {
            InitializeComponent();
        }

        private void ConscriptFindBtn_Click(object sender, EventArgs e)
        {
            Surname = ConscriptFindTextBox.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
