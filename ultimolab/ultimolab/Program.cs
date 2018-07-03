using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ultimolab
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
            nuevabase = new BaseDatos();
            Persona actor1 = new Persona("Brad", "Pitt", "21/03/1965", "Actor", "Gran actor");
            nuevabase.AgregarPersona(actor1);
            Estudio estudio1 = new Estudio("Holiwood", "LA", "09/09/1979");
            nuevabase.AgregarEstudio(estudio1);
            Pelicula pelicula1 = new Pelicula("Mrs and Mr Smith", actor1, "10/12/1998", "Pitt y Jolie", 209898, estudio1);
            nuevabase.AgregarPelicula(pelicula1);


                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(nuevabase));
        }
    }
}
