using System;
using System.Windows.Forms;

namespace Login
{
    public partial class ActivationKeyStore1 : Form
    {
        public ActivationKeyStore1()
        {
            InitializeComponent();
        }

        private void ActivationKeyLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivationKeyStore act = new ActivationKeyStore();
            act.ShowDialog();
            this.Close();
        }
    }
}
