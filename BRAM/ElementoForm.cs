using System;
using System.IO;
using System.Windows.Forms;

namespace BRAM
{
    public partial class ElementoForm : Form
    {
        public string NombreElemento { get; private set; }
        public string TipoElemento { get; private set; } // "Carpeta" o "Archivo"

        public ElementoForm(string tipoElemento)
        {
            InitializeComponent();
            TipoElemento = tipoElemento;
            this.Text = $"Crear {tipoElemento}";
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxElemento.Text))
            {
                MessageBox.Show($"El nombre del {TipoElemento.ToLower()} no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NombreElemento = textBoxElemento.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
