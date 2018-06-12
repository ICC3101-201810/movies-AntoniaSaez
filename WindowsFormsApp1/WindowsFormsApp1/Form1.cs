using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
                buttonVolverAtras.Hide();
                List<Pelicula> peliculas = nuevabase.ObtenerListaPeliculas();
                foreach (Pelicula pelicula in peliculas)
                {
                    string nombre_pelicula = pelicula.GetNombre_Pelicula();
                    string descripcion_pelicula = pelicula.GetDescripcion_Pelicula();
                    string nom_pelicula = ("Pelicula: " + nombre_pelicula);
                    
                    if (nombre_pelicula.Contains(caracteres))
                    {
                        this.listBoxSearch.Items.Add(nom_pelicula);
                    }
                    if (descripcion_pelicula.Contains(caracteres))
                    {
                        this.listBoxSearch.Items.Add(nom_pelicula);
                    }
                }
                List<Persona> personas = nuevabase.ObtenerListaPersonas();
                foreach (Persona persona in personas)
                {
                    string nombre_persona = persona.GetNombre();
                    string apellido_persona = persona.GetApellido();
                    string tipo_persona = persona.GetTipoPersona();
                    string atributos_persona = (tipo_persona + ": " + nombre_persona + " " + apellido_persona);

                    if (nombre_persona.Contains(caracteres))
                    {
                        this.listBoxSearch.Items.Add(atributos_persona);
                    }
                    if (apellido_persona.Contains(caracteres))
                    {
                        this.listBoxSearch.Items.Add(atributos_persona);
                    }
                }
                List<Estudio> estudios = nuevabase.ObtenerListaEstudios();
                foreach (Estudio estudio in estudios)
                {
                    string nombre_estudio = estudio.GetNombre();
                    string direccion_estudio = estudio.GetDireccion();
                    if (nombre_estudio.Contains(caracteres))
                    {
                        this.listBoxSearch.Items.Add(nombre_estudio);
                    }
                    if (direccion_estudio.Contains(caracteres))
                    {
                        this.listBoxSearch.Items.Add(nombre_estudio);
                    }
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

        }

        private void listBoxListaActores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxListaDirectores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxListaProductores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxListaEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {
            buttonVolverAtras.Show();
            listBoxListaActores.Hide();
            listBoxListaDirectores.Hide();
            listBoxListaEstudios.Hide();
            listBoxListaPeliculas.Show();
            listBoxListaProductores.Hide();

            List<Pelicula> peliculas = nuevabase.ObtenerListaPeliculas();
            foreach (Pelicula pelicula in peliculas)
            {
                string nombre_pelicula = pelicula.GetNombre_Pelicula();
                this.listBoxListaPeliculas.Items.Add(nombre_pelicula);
            }
        }

        private void buttonActores_Click(object sender, EventArgs e)
        {
            buttonVolverAtras.Show();
            listBoxListaActores.Show();
            listBoxListaDirectores.Hide();
            listBoxListaEstudios.Hide();
            listBoxListaPeliculas.Hide();
            listBoxListaProductores.Hide();

            List<Persona> actores = nuevabase.ObtenerListaPersonas();
            foreach (Persona persona in actores)
            {
                
                string actor = persona.GetTipoPersona();
                if (actor == "Actor/ Actriz")
                {
                    string nombre_actor = persona.GetNombre();
                    string apellido_actor = persona.GetApellido();
                    string atributos_actor = (nombre_actor + " " + apellido_actor);
                    this.listBoxListaActores.Items.Add(atributos_actor);
                }
            }
                
        }

        private void buttonDirectores_Click(object sender, EventArgs e)
        {
            buttonVolverAtras.Show();
            listBoxListaActores.Hide();
            listBoxListaDirectores.Show();
            listBoxListaEstudios.Hide();
            listBoxListaPeliculas.Hide();
            listBoxListaProductores.Hide();

            List<Persona> directores = nuevabase.ObtenerListaPersonas();
            foreach (Persona persona in directores)
            {

                string director = persona.GetTipoPersona();
                if (director == "Director")
                {
                    string nombre_director = persona.GetNombre();
                    string apellido_director = persona.GetApellido();
                    string atributos_director = (nombre_director + " " + apellido_director);
                    this.listBoxListaDirectores.Items.Add(atributos_director);
                }
            }
        }

        private void buttonProductores_Click(object sender, EventArgs e)
        {
            buttonVolverAtras.Show();
            listBoxListaActores.Hide();
            listBoxListaDirectores.Hide();
            listBoxListaEstudios.Hide();
            listBoxListaPeliculas.Hide();
            listBoxListaProductores.Show();

            List<Persona> productores = nuevabase.ObtenerListaPersonas();
            foreach (Persona persona in productores)
            {

                string productor = persona.GetTipoPersona();
                if (productor == "Productor")
                {
                    string nombre_productor = persona.GetNombre();
                    string apellido_productor = persona.GetApellido();
                    string atributos_productor = (nombre_productor + " " + apellido_productor);
                    this.listBoxListaProductores.Items.Add(atributos_productor);
                }
            }
        }

        private void buttonEstudios_Click(object sender, EventArgs e)
        {
            buttonVolverAtras.Show();
            listBoxListaActores.Hide();
            listBoxListaDirectores.Hide();
            listBoxListaEstudios.Hide();
            listBoxListaPeliculas.Hide();
            listBoxListaProductores.Show();

            List<Estudio> estudios = nuevabase.ObtenerListaEstudios();
            foreach (Estudio estudio in estudios)
            {
                string nombre_estudio = estudio.GetNombre();
                this.listBoxListaEstudios.Items.Add(nombre_estudio);
            }
        }
    }
}
