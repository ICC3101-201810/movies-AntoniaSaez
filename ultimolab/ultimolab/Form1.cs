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

namespace ultimolab
{
    public partial class Form1 : Form
    {
        BaseDatos nuevabase = new BaseDatos();

        public Form1(BaseDatos minuevabaseDatos)
        {
            InitializeComponent();

            nuevabase = minuevabaseDatos;
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelPeliculas.Dock= System.Windows.Forms.DockStyle.Fill;
            panelActores.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDirectores.Dock = System.Windows.Forms.DockStyle.Fill;
            panelEstudios.Dock = System.Windows.Forms.DockStyle.Fill;

            panel1.BringToFront();
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.BringToFront();
            timer1.Stop();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxSearch.Items.Clear();
            string busqueda = textBoxSearch.Text;
            if (busqueda.Length >= 3)
            {
                nuevabase.AgregarBusqueda(busqueda);
                int elementoslistaSearch = listBoxSearch.Items.Count;
                if (elementoslistaSearch == 0)
                {
                    List<string> p = nuevabase.MostrarBusqueda();
                    foreach (string i in p)
                    {
                        int letras = i.Length;
                        this.listBoxSearch.Items.Add(i);
                    }
                }
              
            }
            else
            {
                textBoxSearch.Clear();
                
            }
        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {
            listBoxPeliculas.Items.Clear();
            List<string> peliculas = nuevabase.MostrarPeliculas();
            foreach (string pelicula in peliculas)
            {
                this.listBoxPeliculas.Items.Add(pelicula);
            }
        }

        private void buttonActores_Click(object sender, EventArgs e)
        {
            listBoxActores.Items.Clear();
            List<string> actores = nuevabase.MostrarActores();
            foreach (string actor in actores)
            {
                this.listBoxActores.Items.Add(actor);
            }
        }

        private void buttonDirectores_Click(object sender, EventArgs e)
        {
            listBoxDirectores.Items.Clear();
            List<string> directores = nuevabase.MostrarDirectores();
            foreach (string director in directores)
            {
                this.listBoxDirectores.Items.Add(director);
            }
        }

        private void buttonEstudios_Click(object sender, EventArgs e)
        {
            listBoxEstudios.Items.Clear();
            List<string> estudios = nuevabase.MostrarEstudios();
            foreach (string estudio in estudios)
            {
                this.listBoxEstudios.Items.Add(estudio);
            }
        }

        private void buttonProductores_Click(object sender, EventArgs e)
        {
            listBoxProductores.Items.Clear();
            List<string> productores = nuevabase.MostrarProductores();
            foreach (string productor in productores)
            {
                this.listBoxProductores.Items.Add(productor);
            }
        }

        private void listBoxPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxPeliculas.SelectedItem.ToString();
            panelPeliculas.BringToFront();
            List<Pelicula> peliculas = nuevabase.ObtenerPeliculas();
            foreach (Pelicula pelicula in peliculas)
            {
                string nombre = pelicula.GetNombre();
                if (itemseleccionado == nombre)
                {
                    textBoxNombrePelicula.AppendText(nombre);
                    textBoxNombreDirector.AppendText(pelicula.GetDirector());
                    textBoxEstudio.AppendText(pelicula.GetEstudio());
                    textBoxDescripcionPelicula.AppendText(pelicula.GetDescripcion());
                    textBoxFechaEstreno.AppendText(pelicula.GetFechaEstreno());
                    textBoxPresupuesto.AppendText(pelicula.GetPresupuesto());

                }
            }

        }

        private void listBoxActores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxActores.SelectedItem.ToString();
            panelActores.BringToFront();
            List<Persona> actores = nuevabase.ObtenerPersonas();
            foreach (Persona actor in actores)
            {
                string nombre = actor.GetNombreApelldio();
                if (itemseleccionado == nombre)
                {
                    textBoxNombreyApellido.AppendText(nombre);
                    textBoxFechaNacimiento.AppendText(actor.GetFechaNacimiento());
                    textBoxBiografia.AppendText(actor.GetBiografia());
                }
            }

        }

        private void listBoxDirectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxDirectores.SelectedItem.ToString();
            panelDirectores.BringToFront();
            List<Persona> directores = nuevabase.ObtenerPersonas();
            foreach (Persona director in directores)
            {
                string nombre = director.GetNombreApelldio();
                if (itemseleccionado == nombre)
                {
                    textBoxNombreyApellidoD.AppendText(nombre);
                    textBoxFechaNacimientoD.AppendText(director.GetFechaNacimiento());
                    textBoxBiografiaD.AppendText(director.GetBiografia());
                }
            }

        }

        private void listBoxProductores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxProductores.SelectedItem.ToString();
            panelProductores.BringToFront();
            List<Persona> productores = nuevabase.ObtenerPersonas();
            foreach (Persona productor in productores)
            {
                string nombre = productor.GetNombreApelldio();
                if (itemseleccionado == nombre)
                {
                    textBoxNombreApellidoP.AppendText(nombre);
                    textBoxFechaNacimientoP.AppendText(productor.GetFechaNacimiento());
                    textBoxBiografiaP.AppendText(productor.GetBiografia());
                }
            }

        }

        private void listBoxEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxEstudios.SelectedItem.ToString();
            panelEstudios.BringToFront();
            List<Estudio> estudios = nuevabase.ObtenerEstudios();
            foreach (Estudio estudio in estudios)
            {
                string nombre = estudio.GetNombre();
                if (itemseleccionado == nombre)
                {
                    textBoxNombre.AppendText(nombre);
                    textBoxDireccion.AppendText(estudio.GetDireccion());
                    textBoxFechaApertura.AppendText(estudio.GetFechaApertura());
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonVolverPeliculas_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void buttonVolverActores_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void NombreyApellidoD_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolverDirectores_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void buttonVolverProductores_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void buttonVolverEstudios_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }
    }
}
