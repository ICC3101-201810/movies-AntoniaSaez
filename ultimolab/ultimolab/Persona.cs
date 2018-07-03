using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimolab
{
    public class Persona
    {
        string Nombre;
        string Apellido;
        string FechaNacimiento;
        string Ocupacion;
        string Biografia;

        public Persona(string nombre, string apellido, string fechaNacimiento, string ocupacion, string biografia)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Ocupacion = ocupacion;
            Biografia = biografia;
        }

        public string GetNombreApelldio()
        {
            return (Nombre + " " + Apellido);
        }

        public string GetOcupacion()
        {
            return Ocupacion;
        }
        public string GetFechaNacimiento()
        {
            return FechaNacimiento;
        }
        public string GetBiografia()
        {
            return Biografia;
        }
    }
}
