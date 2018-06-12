using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BaseDatos nuevabase;
            if (File.Exists("../../Serialized.txt"))
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Read);
                nuevabase = (BaseDatos)bin.Deserialize(stream);
                stream.Close();
            }
            else
            {
                nuevabase = new BaseDatos();
                
                DateTime fecha = DateTime.ParseExact("1968-09-12 09", "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
                Persona nuevapersona = new Persona("Brad", "Pitt", fecha, "Director", "Actor talentoso");
                nuevabase.AgregarPersona(nuevapersona);
                Estudio nuevoestudio = new Estudio("Holliwood", "Los Angeles", fecha);
                nuevabase.AgregarEstudio(nuevoestudio);
                Pelicula nuevapelicula = new Pelicula("El extraño caso de Benjamin Button", nuevapersona, fecha, "Muy buena", "$2000", nuevoestudio);
                nuevabase.AgregarPelicula(nuevapelicula);
            }
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(nuevabase));
        }
    }
}
