using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        BaseDatos nuevabase = new BaseDatos();
        public Form1(BaseDatos minuevabasedatos)
        {
            InitializeComponent();
            nuevabase = minuevabasedatos;

            panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;

            panelMenu.BringToFront();
            listBoxSearch.Hide();
            buttonVolverAtras.Hide();
            listBoxListaActores.Hide();
            listBoxListaDirectores.Hide();
            listBoxListaEstudios.Hide();
            listBoxListaPeliculas.Hide();
            listBoxListaProductores.Hide();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string caracteres = textBoxSearch.Text;

            if (caracteres.Length >= 3)
            {
                listBoxSearch.Show();
                buttonVolverAtras.Show();
                List<string> listabusqueda = nuevabase.listastrings();
                foreach (string dato in listabusqueda)
                {
                    if (dato.Contains(caracteres))
                    {
                        this.listBoxSearch.Items.Add(dato);

                    }
                    this.listBoxSearch.Items.Add(dato);
                }
                

            }

        }
        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            listBoxSearch.Hide();
        }

        private void listBoxListaPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panelPeliculas.BringToFront();
        }

        private void listBoxListaActores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panelActor.BringToFront();
        }

        private void listBoxListaDirectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panelDirector.BringToFront();
        }

        private void listBoxListaProductores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panelProductor.BringToFront();
        }

        private void listBoxListaEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //panelEstudio.BringToFront();
        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {

        }
        private void buttonActores_Click(object sender, EventArgs e)
        {

        }
        private void buttonProductores_Click(object sender, EventArgs e)
        {

        }
        private void buttonDirectores_Click(object sender, EventArgs e)
        {

        }
        private void buttonEstudios_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            if (File.Exists("../../Serialized.txt"))
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Write);
                bin.Serialize(stream, nuevabase);
                stream.Close();
            }
            else
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Create, FileAccess.Write);
                bin.Serialize(stream, nuevabase);
                stream.Close();
            }
            Application.Exit();
        }

        private void listBoxSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
