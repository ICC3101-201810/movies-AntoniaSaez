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

    }
}
