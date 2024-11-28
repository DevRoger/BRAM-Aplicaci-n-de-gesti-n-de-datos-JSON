using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BRAM
{
    public partial class Inicio : Form
    {
        // Atributos
        DirectoryInfo directorioActual;
        List<DirFich> archivos = new List<DirFich>();
        List<Alumno> alumnos = new List<Alumno>();
        string selectedFile;

        /// <summary>
        /// Inicializa el formulario.
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Muestra una pestaña para escoger directorio en el que trabajar en la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();

            archivos.Clear();

            if (result == DialogResult.OK)
            {
                textBoxPath.Text = folder.SelectedPath;

                directorioActual = new DirectoryInfo(textBoxPath.Text);

                listViewArchivos.Items.Clear(); // Limpiar los elementos existentes

                // Mostrar directorios
                foreach (DirectoryInfo subdir in directorioActual.GetDirectories())
                {
                    DirFich dirFich = new DirFich
                    {
                        Nombre = subdir.Name,
                        NombreEntero = subdir.FullName
                    };
                    archivos.Add(dirFich);

                    // Agregar directorio al ListView
                    var item = new ListViewItem(subdir.Name)
                    {
                        ImageIndex = 0, // Índice para ícono de directorio en ImageList (opcional)
                        Tag = dirFich   // Asocia el objeto DirFich
                    };
                    listViewArchivos.Items.Add(item);
                }

                // Mostrar archivos
                foreach (FileInfo fichero in directorioActual.GetFiles())
                {
                    DirFich dirFich = new DirFich
                    {
                        Nombre = fichero.Name,
                        NombreEntero = fichero.FullName
                    };
                    archivos.Add(dirFich);

                    // Agregar archivo al ListView
                    var item = new ListViewItem(fichero.Name)
                    {
                        ImageIndex = 1, // Índice para ícono de archivo en ImageList (opcional)
                        Tag = dirFich   // Asocia el objeto DirFich
                    };
                    listViewArchivos.Items.Add(item);
                }
            }
        }


        /// <summary>
        /// Filtra los documentos en el ListView mostrando solamente los JSONs, o todos los elementos (archivos y directorios) si el filtro está desactivado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxJSON_CheckedChanged(object sender, EventArgs e)
        {
            if (directorioActual == null)
            {
                return;
            }

            archivos.Clear();
            listViewArchivos.Items.Clear(); // Limpiar los elementos existentes

            if (checkBoxJSON.Checked)
            {
                // Filtrar solo archivos JSON
                var filteredFiles = directorioActual.GetFiles()
                    .Where(f => f.Extension.ToLower() == ".json");

                foreach (FileInfo fichero in filteredFiles)
                {
                    DirFich dirFich = new DirFich
                    {
                        Nombre = fichero.Name,
                        NombreEntero = fichero.FullName
                    };
                    archivos.Add(dirFich);

                    // Agregar archivo JSON al ListView con ícono de archivo (índice 1)
                    var item = new ListViewItem(fichero.Name)
                    {
                        ImageIndex = 1, // Índice para ícono de archivo en el ImageList
                        Tag = dirFich
                    };
                    listViewArchivos.Items.Add(item);
                }
            }
            else
            {
                // Mostrar todos los archivos y directorios

                // Agregar directorios
                foreach (DirectoryInfo subdir in directorioActual.GetDirectories())
                {
                    DirFich dirFich = new DirFich
                    {
                        Nombre = subdir.Name,
                        NombreEntero = subdir.FullName
                    };
                    archivos.Add(dirFich);

                    // Agregar directorio al ListView con ícono de directorio (índice 0)
                    var item = new ListViewItem(subdir.Name)
                    {
                        ImageIndex = 0, // Índice para ícono de directorio en el ImageList
                        Tag = dirFich
                    };
                    listViewArchivos.Items.Add(item);
                }

                // Agregar archivos
                foreach (FileInfo fichero in directorioActual.GetFiles())
                {
                    DirFich dirFich = new DirFich
                    {
                        Nombre = fichero.Name,
                        NombreEntero = fichero.FullName
                    };
                    archivos.Add(dirFich);

                    // Agregar archivo al ListView con ícono de archivo (índice 1)
                    var item = new ListViewItem(fichero.Name)
                    {
                        ImageIndex = 1, // Índice para ícono de archivo en el ImageList
                        Tag = dirFich
                    };
                    listViewArchivos.Items.Add(item);
                }
            }

            // Cambiar el ícono del CheckBox (opcional)
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
                chk.Image = Properties.Resources.icons8_casilla_de_verificación_marcada_26;
            else
                chk.Image = Properties.Resources.icons8_casilla_de_verificación_desactivada_26;
        }



        /// <summary>
        /// Inicializa el formulario con los datos del JSON seleccionados. Si el archivo seleccionado no es un JSON, salta un aviso de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResults_Click(object sender, EventArgs e)
        {
            // Clear existing data in alumnos list before loading from JSON
            alumnos.Clear();

            if (Path.GetExtension(selectedFile).ToLower() == ".json")
            {
                try
                {
                    string jsonData = File.ReadAllText(selectedFile);
                    var alumnosData = JsonConvert.DeserializeObject<List<Alumno>>(jsonData);

                    foreach (var alumnoData in alumnosData)
                    {
                        Alumno alumno = new Alumno
                        {
                            Nombre = alumnoData.Nombre
                        };

                        foreach (var partidaData in alumnoData.Partidas)
                        {
                            Partida partida = new Partida
                            {
                                Modo = partidaData.Modo,
                                Fecha = partidaData.Fecha,
                                Errores = partidaData.Errores,
                                TiemposAnimales = partidaData.TiemposAnimales
                            };

                            alumno.Partidas.Add(partida);
                        }

                        alumnos.Add(alumno);
                    }

                    this.Hide();
                    Resultados resultados = new Resultados(alumnos);
                    resultados.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading JSON file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selected file is not a JSON file.");
            }
        }

        /// <summary>
        /// Devuelve el nombre del archivo seleccionado en el listViewArchivos.
        /// </summary>
        private void listViewArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewArchivos.SelectedItems.Count > 0)
            {
                int index = listViewArchivos.SelectedItems[0].Index;
                selectedFile = archivos[index].NombreEntero;
            }
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            BRAM bram = new BRAM();
            bram.Show();
        }
    }
}
