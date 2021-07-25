using System;
using System.Windows.Forms;

namespace Login
{
    public partial class ActivationKeyMarket1 : Form
    {
        public ActivationKeyMarket1()
        {
            InitializeComponent();
        }

        private void ActivationKeyLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivationKeyMarket actm = new ActivationKeyMarket();
            actm.ShowDialog();
            this.Close();
        }
    }
}
