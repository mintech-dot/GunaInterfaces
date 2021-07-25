using System;
using System.Windows.Forms;

namespace Login
{
    public partial class ActivationKey : Form
    {
        public ActivationKey()
        {
            InitializeComponent();
        }


        private void RequestActivationKey_Click(object sender, EventArgs e)
        {

            this.Hide();
            ActivationKey1 actKey = new ActivationKey1();
            actKey.ShowDialog();
            this.Close();
        }
    }
}
