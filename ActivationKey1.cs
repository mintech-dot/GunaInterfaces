using System;
using System.Windows.Forms;

namespace Login
{
    public partial class ActivationKey1 : Form
    {
        public ActivationKey1()
        {
            InitializeComponent();
        }

        private void ActivationKeyLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivationKey actKey = new ActivationKey();
            actKey.ShowDialog();
            this.Close();
        }
    }
}
