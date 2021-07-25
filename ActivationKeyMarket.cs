using System;
using System.Windows.Forms;

namespace Login
{
    public partial class ActivationKeyMarket : Form
    {
        public ActivationKeyMarket()
        {
            InitializeComponent();
        }

        private void RequestActivationKeyLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivationKeyMarket1 act = new ActivationKeyMarket1();
            act.ShowDialog();
            this.Close();
        }
    }
}
