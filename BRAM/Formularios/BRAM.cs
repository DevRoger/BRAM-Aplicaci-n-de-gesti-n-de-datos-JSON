using System;
using System.Windows.Forms;

namespace BRAM
{
    public partial class BRAM : Form
    {
        public BRAM()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            this.Hide();
            i.Show();
        }

        private void BRAM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
