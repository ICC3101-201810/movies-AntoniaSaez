using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    public class Pelicula
    {
        string Nombre;
        Persona Director;
        DateTime Fecha_de_estreno;
        string Descripcion;
        string Presupuesto;
        Estudio estudio;

        public Pelicula(string miNombre, Persona miDirector, DateTime miFecha_de_estreno, string miDescripcion, string miPresupuesto, Estudio miEstudio)
        {
            miNombre = Nombre;
            miDirector = Director;
            miFecha_de_estreno = Fecha_de_estreno;
            miDescripcion = Descripcion;
            miPresupuesto = Presupuesto;
            miEstudio = estudio;
        }

        public string GetNombre_Pelicula()
        {
            return Nombre;
        }

        public string GetDescripcion_Pelicula()
        {
            return Descripcion;
        }
    }
}
