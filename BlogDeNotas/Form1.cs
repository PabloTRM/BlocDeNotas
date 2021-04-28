using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogDeNotas
{

    public partial class Form1 : Form
    {
        //Primero vamos a declarar y luego crear un objeto nota, y una lista de notas.

        private Nota nota;
        private List<Nota> notas;
        private String descripcion;
        public Form1()
        {

            notas = new List<Nota>();
            rellenarFicheroLista();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //creamos una nota, comprobamos que ningún campo esté vació, no pedimos la fecha porque siempre trabajamos
            //con el local date, tanto para crearla como para actualizarla.
            nota = new Nota();
            if (txtAutor.Text != "" && txtDescripcion.Text != "")
            {
                StreamWriter fichero = null;
                try
                {

                    //Crear fichero, si existe lo agrega al final
                    fichero = File.AppendText("agenda.txt");
                    //Escribe en el fichero
                    fichero.WriteLine(txtAutor.Text + "#" + txtDescripcion.Text + "#" + DateTime.Now);

                }
                catch (Exception exception) { MessageBox.Show("Error al crear fichero"); }
                finally
                {
                    try
                    {
                        if (fichero != null) fichero.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("error");
                    }
                }

                nota.Autor = txtAutor.Text;
                nota.Descripcion = txtDescripcion.Text;
                nota.Fecha = DateTime.Now;

                notas.Add(nota);
                actualizarCb();
            }
            else
            {
                MessageBox.Show("Rellena todos los campos");

            }

            txtAutor.Clear();
            txtDescripcion.Clear();
        }

        private void cbConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbConsultar.SelectedIndex;
            descripcion = cbConsultar.Text;
            //rellenamos el comboBox 

            Nota notaelegida = notas[index];
            mostrarTxt();

            txtFechaConsultar.Text = notaelegida.Fecha.ToString();
            txtNombreConsultar.Text = notaelegida.Autor;
            txtNotaConsultar.Text = notaelegida.Descripcion;

        }
        //como repito el código en eliminar y en modificar lo he extraido a una función y luego la llamo en cada caso.
        private void mostrarTxt()
        {
            txtFechaConsultar.Visible = true;
            txtNombreConsultar.Visible = true;
            txtNotaConsultar.Visible = true;
            lblConsultarFecha.Visible = true;
            lblConsultarNota.Visible = true;
            lblNombreConsultar.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            StreamWriter fichero = null;
            //Eliminar nota y modificiar nota funcionan bastante similiar, si el combobox tiene items y 
            //hay al menos un item seleccionado elimina o modifica
            if (cbConsultar.Items.Count == 0 || cbConsultar.SelectedItem == null)
            {
                MessageBox.Show("ERROR, No hay nota seleccionada o no hay nota creada");
            }
            else
            {
                try
                {
                    notas.RemoveAt(cbConsultar.SelectedIndex);


                    fichero = File.CreateText("agenda.txt");
                    foreach (Nota nota in notas)
                    {
                        fichero.WriteLine(nota.Autor + "#" + nota.Descripcion + "#" + nota.Fecha);

                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    try
                    {
                        if (fichero != null) fichero.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("error");
                    }
                }


                Ocultartxt();
            }

        }

        private void Ocultartxt()
        {
            txtFechaConsultar.Visible = false;
            txtNombreConsultar.Visible = false;
            txtNotaConsultar.Visible = false;
            lblConsultarFecha.Visible = false;
            lblConsultarNota.Visible = false;
            lblNombreConsultar.Visible = false;
            actualizarCb();
        }

        private void actualizarCb()
        {
            //método que usamos para cuando borramos o modificamos para volver a llenar los campos del comboBox
            cbConsultar.Items.Clear();

            if (rbtnFecha.Checked)
            {
                cbConsultar.Items.Clear();
                foreach (Nota nota in notas)
                {
                    cbConsultar.Items.Add(nota.Fecha);
                }

            }
            else
            {
                if (rbtonDescripcion.Checked)
                {
                    cbConsultar.Items.Clear();
                    foreach (Nota nota in notas)
                    {
                        cbConsultar.Items.Add(nota.Descripcion);
                    }
                }
                else
                {
                    if (rdbtnAutor.Checked)
                    {
                        cbConsultar.Items.Clear();
                        foreach (Nota nota in notas)
                        {
                            cbConsultar.Items.Add(nota.Autor);
                        }
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (cbConsultar.Items.Count == 0 || cbConsultar.SelectedItem == null)
            {
                MessageBox.Show("ERROR, No hay nota seleccionada" +
" o no hay nota creada");
            }

            else
            {

                notas[cbConsultar.SelectedIndex].Autor = txtNombreConsultar.Text;
                notas[cbConsultar.SelectedIndex].Descripcion = txtNotaConsultar.Text;
                notas[cbConsultar.SelectedIndex].Fecha = DateTime.Now;


                StreamWriter fichero = null;
                try
                {
                    fichero = File.CreateText("agenda.txt");
                    foreach (Nota nota in notas)
                    {
                        fichero.WriteLine(nota.Autor + "#" + nota.Descripcion + "#" + nota.Fecha);

                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("error");
                }
                finally
                {
                    try
                    {
                        if (fichero != null)

                            fichero.Close();
                    }
                    catch (Exception error) { MessageBox.Show("error"); }

                    Ocultartxt();
                }
            }
        }


        private void cambiarCheckRadioBtn(object sender, EventArgs e)
        {
            actualizarCb();
            Ocultartxt();
        }
        private void rellenarFicheroLista()
        {
            String linea = null;
            StreamReader fichero = null;
            try
            {
                fichero = File.OpenText("agenda.txt");
                linea = fichero.ReadLine();
                while (linea != null)
                {
                    String[] trozos = linea.Split('#');
                    notas.Add(new Nota(DateTime.Parse(trozos[2]), trozos[0], trozos[1]));
                    linea = fichero.ReadLine();
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("error");
            }
            finally
            {
                try
                {
                    if (fichero != null)

                        fichero.Close();
                    

                }
                catch (Exception error) { MessageBox.Show("error"); }

                
            }

        }
    
    }


}
