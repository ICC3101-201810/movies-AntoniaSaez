﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    public class PeliculaActor
    {
        Pelicula pelicula;
        Persona actor;

        public PeliculaActor(Pelicula miPelicula, Persona miActor)
        {
            miPelicula = pelicula;
            miActor = actor;
        }
    }
}
