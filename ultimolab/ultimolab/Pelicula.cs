using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimolab
{
    public class Pelicula
    {
        string Nombre;
        Persona Director;
        string FechaEstreno;
        string Descripcion;
        int Presupuesto;
        Estudio Estudio;

        public Pelicula(string miNombre, Persona miDirector, string miFechaEstreno, string miDescripcion, int miPresupuesto, Estudio miEstudio)
        {
            Nombre = miNombre;
            Director = miDirector;
            FechaEstreno = miFechaEstreno;
            Descripcion = miDescripcion;
            Presupuesto = miPresupuesto;
            Estudio = miEstudio;
            
        }
        public string NombreDescripcion()
        {
            return (Nombre + " - " + Descripcion);
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetDirector()
        {
            return Director.GetNombreApelldio();
        }
        public string GetFechaEstreno()
        {
            return FechaEstreno;
        }
        public string GetDescripcion()
        {
            return Descripcion;
        }
        public string GetPresupuesto()
        {
            return Presupuesto.ToString();
        }
        public string GetEstudio()
        {
            return Estudio.GetNombre();
        }
    }
}
