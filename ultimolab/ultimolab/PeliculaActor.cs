using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimolab
{
    public class PeliculaActor
    {
        Pelicula Pelicula;
        Persona Actor;

        public PeliculaActor(Pelicula pelicula, Persona actor)
        {
            Pelicula = pelicula;
            Actor = actor;
        }
    }
}
