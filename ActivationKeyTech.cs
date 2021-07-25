using System;
using System.Windows.Forms;

namespace Login
{
    public partial class ActivationKeyTech : Form
    {
        public ActivationKeyTech()
        {
            InitializeComponent();
        }

        private void RequestActivationKeyLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivationKeyTech1 act = new ActivationKeyTech1();
            act.ShowDialog();
            this.Close();
        }
    }
}
