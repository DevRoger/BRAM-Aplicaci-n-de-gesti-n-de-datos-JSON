using System;
using System.IO;
using System.Windows.Forms;

namespace BRAM
{
    public partial class InputBox : Form
    {
        public string NuevoNombre { get; private set; }
        private string RutaActual { get; set; }

        public InputBox(string rutaActual, string nombreActual)
        {
            InitializeComponent();
            RutaActual = rutaActual;
            textBoxNuevoNombre.Text = nombreActual;  // Poner el nombre actual en el TextBox
        }

        /// <summary>
        /// Devuelve OK si el cambio de nombre ha sido correcto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string nuevoNombre = textBoxNuevoNombre.Text.Trim();

            // Validar que el nuevo nombre no esté vacío
            if (string.IsNullOrEmpty(nuevoNombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevaRuta = Path.Combine(Path.GetDirectoryName(RutaActual), nuevoNombre);

            // Verificar si ya existe un archivo o carpeta con ese nombre
            if (File.Exists(nuevaRuta) || Directory.Exists(nuevaRuta))
            {
                MessageBox.Show("Ya existe un archivo o carpeta con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Todo está en orden, guardamos el nuevo nombre
            NuevoNombre = nuevoNombre;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Devuelve KO si el cambio de nombre ha sido insatisfactorio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
