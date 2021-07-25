using System;
using System.Windows.Forms;

namespace Login
{
    public partial class ActivationKeyStore : Form
    {
        public ActivationKeyStore()
        {
            InitializeComponent();
        }

        private void RequestActivationKeyLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivationKeyStore1 act = new ActivationKeyStore1();
            act.ShowDialog();
            this.Close();
        }
    }
}
