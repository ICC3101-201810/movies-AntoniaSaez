using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Estudio
    {
        string Nombre;
        string Direccion;
        DateTime Fecha_Apertura;

        public Estudio(string miNombre, string miDireccion, DateTime miFecha_Apertura)
        {
            miNombre = Nombre;
            miDireccion = Direccion;
            miFecha_Apertura = Fecha_Apertura;
        }

        public string GetNombre()
        {
            return Nombre;
        }
        public string GetDireccion()
        {
            return Direccion;
        }
    }
}
