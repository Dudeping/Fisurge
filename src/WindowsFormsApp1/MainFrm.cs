using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            var comb = new CombFrm();

            comb.ShowDialog();
        }

        private void BtnComb_Click(object sender, EventArgs e)
        {
            var comb = new CombFrm();

            comb.ShowDialog();
        }
    }
}
