using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimolab
{
    public class PeliculaProductor
    {
        Pelicula Pelicula;
        Persona Productor;

        public PeliculaProductor(Pelicula pelicula, Persona productor)
        {
            Pelicula = pelicula;
            Productor = productor;
        }
    }
}
