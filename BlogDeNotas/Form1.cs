using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //creamos una nota, comprobamos que ningún campo esté vació, no pedimos la fecha porque siempre trabajamos
            //con el local date, tanto para crearla como para actualizarla.
            nota = new Nota();
            if (txtAutor.Text !="" && txtDescripcion.Text!="") {
                nota.Autor = txtAutor.Text;
                nota.Descripcion = txtDescripcion.Text;
                nota.Fecha = DateTime.Now;

                notas.Add(nota);
                cbConsultar.Items.Add(nota.Descripcion);
            }
            else { MessageBox.Show("Rellena todos los campos");
            
            }

            txtAutor.Clear();
            txtDescripcion.Clear();
        }

        private void cbConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {
             descripcion = cbConsultar.Text;
            //rellenamos el comboBox recorriendo toda la lista de notas
            foreach (Nota nota in notas)
            {
            
              if(cbConsultar.Items.Count>0)
                {
                    mostrarTxt();

                    txtFechaConsultar.Text = nota.Fecha.ToString();
                    txtNombreConsultar.Text = nota.Autor;
                    txtNotaConsultar.Text = nota.Descripcion;

                }
            }
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
            //Eliminar nota y modificiar nota funcionan bastante similiar, si el combobox tiene items y 
            //hay al menos un item seleccionado elimina o modifica
            if (cbConsultar.Items.Count==0 || cbConsultar.SelectedItem==null) {
                MessageBox.Show("ERROR, No hay nota seleccionada o no hay nota creada");
            }
            else
            {
                notas.RemoveAt(cbConsultar.SelectedIndex);
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
            foreach (Nota nota in notas)
            {
                cbConsultar.Items.Add(nota.Descripcion);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (cbConsultar.Items.Count == 0 || cbConsultar.SelectedItem == null) { MessageBox.Show("ERROR, No hay nota seleccionada" +
                " o no hay nota creada"); }

            else
            {
                
                notas[cbConsultar.SelectedIndex].Autor = txtNombreConsultar.Text;
                notas[cbConsultar.SelectedIndex].Descripcion = txtNotaConsultar.Text;
                notas[cbConsultar.SelectedIndex].Fecha = DateTime.Now;
                Ocultartxt();
            }
        }

    }
    
}
