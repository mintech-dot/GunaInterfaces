using System;
using System.Windows.Forms;

namespace Login
{
    public partial class ActivationKeyTech1 : Form
    {
        public ActivationKeyTech1()
        {
            InitializeComponent();
        }

        private void ActivationKeyLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActivationKeyTech act = new ActivationKeyTech();
            act.ShowDialog();
            this.Close();
        }
    }
}
