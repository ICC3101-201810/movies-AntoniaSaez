using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    public class Persona
    {
        string Nombre;
        string Apellido;
        DateTime FechaNacimiento;
        string tipo;
        //actor, productor, director
        string Biografia;

        public Persona(string miNombre, string miApellido, DateTime miFechaNacimiento, string mitipo, string miBiografia)
        {
            miNombre = Nombre;
            miApellido = Apellido;
            miFechaNacimiento = FechaNacimiento;
            mitipo = tipo;
            miBiografia = Biografia;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetApellido()
        {
            return Apellido;
        }
        public string GetTipoPersona()
        {
            return tipo;
        }
    }
}
