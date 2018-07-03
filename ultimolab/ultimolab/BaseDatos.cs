using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimolab
{
    public class BaseDatos
    {
        List<Persona> personas;
        List<Pelicula> peliculas;
        List<Estudio> estudios;
        List<string> busqueda;

        public BaseDatos()
        {
            personas = new List<Persona>();
            peliculas = new List<Pelicula>();
            estudios = new List<Estudio>();
            busqueda = new List<string>();
        }

        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }
        public void AgregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }
        public void AgregarEstudio(Estudio estudio)
        {
            estudios.Add(estudio);
        }
        public List<Pelicula> ObtenerPeliculas()
        {
            return peliculas;
        }
        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }
        public List<Estudio> ObtenerEstudios()
        {
            return estudios;
        }

        public void AgregarBusqueda (string palabra)
        {
            busqueda.Clear();
            foreach (Persona persona in personas)
            {
                string nombreyapellido = persona.GetNombreApelldio();
                string ocupacion = persona.GetOcupacion();
                if (nombreyapellido.ToLower().Contains(palabra) == true)
                {
                    string personabuscada = (ocupacion + " - " + nombreyapellido);
                    busqueda.Add(personabuscada);
                }

            }
            foreach (Pelicula pelicula in peliculas)
            {
                string nombreydescripcion = pelicula.NombreDescripcion();
                if (nombreydescripcion.ToLower().Contains(palabra) == true)
                {
                    busqueda.Add(nombreydescripcion);
                }
            }
            foreach (Estudio estudio in estudios)
            {
                string nomnbreydireccion = estudio.GetNombreDireccion();
                if (nomnbreydireccion.ToLower().Contains(palabra) == true)
                {
                    busqueda.Add(nomnbreydireccion);
                }
            }
        }
        public List<string> MostrarBusqueda()
        {
            return busqueda;
        }
        public List<string> MostrarPeliculas()
        {
            busqueda.Clear();
            foreach (Pelicula pelicula in peliculas)
            {
                string nombre = pelicula.GetNombre();
                busqueda.Add(nombre);
            }
            return busqueda;
        }
        public List<string> MostrarActores()
        {
            busqueda.Clear();
            foreach (Persona persona in personas)
            {
                string actor = persona.GetOcupacion();
                if (actor == "Actor")
                {
                    string nombreactor = persona.GetNombreApelldio();
                    busqueda.Add(nombreactor);
                }
                return busqueda;
            }
            return null;
        }
        public List<string> MostrarDirectores()
        {
            busqueda.Clear();
            foreach (Persona persona in personas)
            {
                string director = persona.GetOcupacion();
                if (director == "Director")
                {
                    string nombredirector = persona.GetNombreApelldio();
                    busqueda.Add(nombredirector);
                }
                return busqueda;
            }
            return null;
        }
        public List<string> MostrarProductores()
        {
            busqueda.Clear();
            foreach (Persona persona in personas)
            {
                string productor = persona.GetOcupacion();
                if (productor == "Productor")
                {
                    string nombreproductor = persona.GetNombreApelldio();
                    busqueda.Add(nombreproductor);
                }
                return busqueda;
            }
            return null;
        }
        public List<string> MostrarEstudios()
        {
            busqueda.Clear();
            foreach (Estudio estudio in estudios)
            {
                string nombre = estudio.GetNombre();
                busqueda.Add(nombre);
            }
            return busqueda;
        }


    }
}
