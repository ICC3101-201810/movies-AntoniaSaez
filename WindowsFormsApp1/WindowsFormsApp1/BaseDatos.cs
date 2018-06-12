using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class BaseDatos
    {
        List<Pelicula> listaPeliculas;
        List<Persona> listaPersonas;
        List<Persona> listaActores;
        List<Persona> listProductores;
        List<Persona> listaDirectores;
        List<Estudio> listaEstudios;

        public BaseDatos()
        {
            listaPeliculas = new List<Pelicula>();
            listaPersonas = new List<Persona>();
            listaActores = new List<Persona>();
            listProductores = new List<Persona>();
            listaDirectores = new List<Persona>();
            listaEstudios = new List<Estudio>();

        }
        public List<Pelicula> ObtenerListaPeliculas()
        {
            return listaPeliculas; 
            
        }
        public List<Persona> ObtenerListaPersonas()
        {
            return listaPersonas;

        }

        public List<Estudio> ObtenerListaEstudios()
        {
            return listaEstudios;

        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return listaPeliculas;
        }

        public void AgregarPersona(Persona persona)
        {
            listaPersonas.Add(persona);
        }

        public void AgregarPelicula(Pelicula pelicula)
        {
            listaPeliculas.Add(pelicula);
        }

        public void AgregarEstudio(Estudio estudio)
        {
            listaEstudios.Add(estudio);
        }
    }
}
