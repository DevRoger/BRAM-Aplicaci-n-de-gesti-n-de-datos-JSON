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
        // Atributos declarados
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

            // Asociar el evento DoubleClick al ListView
            listViewArchivos.DoubleClick += ListViewArchivos_DoubleClick;
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
                        ImageIndex = 0, // Índice para ícono de directorio en ImageList
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

                    // Si el archivo es un JSON, asignar el índice 2 para el icono
                    int imageIndex = fichero.Extension.ToLower() == ".json" ? 2 : 1;

                    // Agregar archivo al ListView con el icono correspondiente
                    var item = new ListViewItem(fichero.Name)
                    {
                        ImageIndex = imageIndex, // Índice para ícono (2 para JSON)
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

                    // Agregar archivo JSON al ListView con ícono de archivo JSON (índice 2)
                    var item = new ListViewItem(fichero.Name)
                    {
                        ImageIndex = 2, // Índice para ícono de archivo JSON en ImageList
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
                        ImageIndex = 0, // Índice para ícono de directorio en ImageList
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

                    // Asignar el índice adecuado según la extensión del archivo
                    int imageIndex = fichero.Extension.ToLower() == ".json" ? 2 : 1;

                    // Agregar archivo al ListView con el ícono correspondiente
                    var item = new ListViewItem(fichero.Name)
                    {
                        ImageIndex = imageIndex, // Índice para ícono (2 para JSON, 1 para otros archivos)
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
            Application.Exit();
        }

        /// <summary>
        /// Maneja el evento de doble clic en el ListView para navegar a carpetas o abrir archivos JSON.
        /// </summary>
        private void ListViewArchivos_DoubleClick(object sender, EventArgs e)
        {
            if (listViewArchivos.SelectedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                ListViewItem selectedItem = listViewArchivos.SelectedItems[0];
                DirFich dirFich = selectedItem.Tag as DirFich;

                if (dirFich != null)
                {
                    // Si es un directorio, navegar a él
                    if (Directory.Exists(dirFich.NombreEntero))
                    {
                        directorioActual = new DirectoryInfo(dirFich.NombreEntero);
                        textBoxPath.Text = directorioActual.FullName;
                        ActualizarContenidoDirectorio();
                    }
                    // Si es un archivo JSON, cargarlo y abrir el formulario de resultados
                    else if (File.Exists(dirFich.NombreEntero) && Path.GetExtension(dirFich.NombreEntero).ToLower() == ".json")
                    {
                        CargarYMostrarResultados(dirFich.NombreEntero);
                    }
                    else
                    {
                        MessageBox.Show("El archivo seleccionado no es un archivo JSON válido.");
                    }
                }
            }
        }

        /// <summary>
        /// Actualiza el contenido del ListView con los elementos del directorio actual.
        /// </summary>
        private void ActualizarContenidoDirectorio()
        {
            archivos.Clear();
            listViewArchivos.Items.Clear();

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
                    ImageIndex = 0, // Ícono de carpeta
                    Tag = dirFich
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
                    ImageIndex = 1, // Ícono de archivo
                    Tag = dirFich
                };
                listViewArchivos.Items.Add(item);
            }
        }

        /// <summary>
        /// Carga el archivo JSON y navega al formulario de resultados.
        /// </summary>
        /// <param name="rutaArchivo">Ruta completa del archivo JSON.</param>
        private void CargarYMostrarResultados(string rutaArchivo)
        {
            try
            {
                // Limpiar datos previos
                alumnos.Clear();

                // Leer y verificar si el archivo JSON está vacío
                string jsonData = File.ReadAllText(rutaArchivo);
                if (string.IsNullOrWhiteSpace(jsonData))
                {
                    MessageBox.Show("El archivo JSON está vacío. Por favor, selecciona un archivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método
                }

                // Deserializar el archivo JSON
                var alumnosData = JsonConvert.DeserializeObject<List<Alumno>>(jsonData);
                if (alumnosData == null || alumnosData.Count == 0)
                {
                    MessageBox.Show("El archivo JSON no contiene datos válidos. Por favor, selecciona un archivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método
                }

                // Procesar datos deserializados
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

                // Ocultar este formulario y mostrar el de resultados
                this.Hide();
                Resultados resultados = new Resultados(alumnos, rutaArchivo);
                resultados.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el archivo JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDirCreate_Click(object sender, EventArgs e)
        {
            CrearElemento("Carpeta");
        }

        private void buttonFichCreate_Click(object sender, EventArgs e)
        {
            CrearElemento("Archivo");
        }

        private void CrearElemento(string tipoElemento)
        {
            if (directorioActual == null)
            {
                MessageBox.Show("Por favor, selecciona un directorio en el que crear el elemento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (ElementoForm form = new ElementoForm(tipoElemento))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string nuevoElemento = Path.Combine(directorioActual.FullName, form.NombreElemento);

                    try
                    {
                        if (tipoElemento == "Carpeta")
                        {
                            // Crear carpeta
                            if (Directory.Exists(nuevoElemento))
                            {
                                MessageBox.Show("Ya existe una carpeta con ese nombre en el directorio seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                Directory.CreateDirectory(nuevoElemento);
                                MessageBox.Show("La carpeta se creó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (tipoElemento == "Archivo")
                        {
                            // Crear archivo
                            if (File.Exists(nuevoElemento))
                            {
                                MessageBox.Show("Ya existe un archivo con ese nombre en el directorio seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                File.Create(nuevoElemento).Dispose();
                                MessageBox.Show("El archivo se creó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        // Actualizar el contenido del ListView
                        ActualizarContenidoDirectorio();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al crear el {tipoElemento.ToLower()}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonFichDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFile))
            {
                MessageBox.Show("Por favor, selecciona un archivo o carpeta del ListView para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verificar si el archivo o carpeta existe antes de intentar eliminarlo
                if (File.Exists(selectedFile))
                {
                    // Confirmar la eliminación con el usuario
                    DialogResult confirmResult = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar el archivo '{Path.GetFileName(selectedFile)}'?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        File.Delete(selectedFile);
                        MessageBox.Show("El archivo se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el contenido del ListView
                        ActualizarContenidoDirectorio();
                    }
                }
                else if (Directory.Exists(selectedFile))
                {
                    // Confirmar la eliminación con el usuario para una carpeta
                    DialogResult confirmResult = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar la carpeta '{Path.GetFileName(selectedFile)}'?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        Directory.Delete(selectedFile, true);  // Eliminar la carpeta y su contenido
                        MessageBox.Show("La carpeta se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el contenido del ListView
                        ActualizarContenidoDirectorio();
                    }
                }
                else
                {
                    MessageBox.Show("El archivo o carpeta seleccionado(a) ya no existe. Puede haber sido movido o eliminado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar el archivo o carpeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFichMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFile))
            {
                MessageBox.Show("Por favor, selecciona un archivo o carpeta para modificar su nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear y mostrar el formulario de renombrado
            string nombreActual = Path.GetFileName(selectedFile);
            using (InputBox formRenombrar = new InputBox(selectedFile, nombreActual))
            {
                if (formRenombrar.ShowDialog() == DialogResult.OK)
                {
                    // Obtener el nuevo nombre del formulario
                    string nuevoNombre = formRenombrar.NuevoNombre;
                    string directorio = Path.GetDirectoryName(selectedFile);
                    string nuevaRuta = Path.Combine(directorio, nuevoNombre);

                    try
                    {
                        // Renombrar el archivo o carpeta
                        if (File.Exists(selectedFile))
                        {
                            File.Move(selectedFile, nuevaRuta);
                            MessageBox.Show("El archivo se renombró correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Directory.Exists(selectedFile))
                        {
                            Directory.Move(selectedFile, nuevaRuta);
                            MessageBox.Show("La carpeta se renombró correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Actualizar el contenido del ListView
                        ActualizarContenidoDirectorio();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al intentar renombrar el archivo o carpeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
