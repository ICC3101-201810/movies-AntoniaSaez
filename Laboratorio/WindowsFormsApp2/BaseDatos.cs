using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WindowsFormsApp2
{
    [Serializable]
    public class BaseDatos
    {
        List<Pelicula> listaPeliculas = new List<Pelicula>();
        List<Persona> listaPersonas = new List<Persona>();
        List<Estudio> listaEstudios = new List<Estudio>();

        public List<string> listastrings()
        {
            List<string> buscador = new List<string>();
            
            foreach (Pelicula pelicula in listaPeliculas)
            {
                string nombre_pelicula = pelicula.GetNombre_Pelicula();
                string descripcion_pelicula = pelicula.GetDescripcion_Pelicula();
                string atributos_pelicula = (nombre_pelicula + " , " + descripcion_pelicula);
                buscador.Add(atributos_pelicula);
            }
            foreach (Persona persona in listaPersonas)
            {
                string nombre_persona = persona.GetNombre();
                string apellido_persona = persona.GetApellido();
                string tipo_persona = persona.GetTipoPersona();
                string atributos_persona = (nombre_persona + " " + apellido_persona);
                buscador.Add(atributos_persona);
            }
            
            foreach (Estudio estudio in listaEstudios)
            {
                string nombre_estudio = estudio.GetNombre();
                string direccion_estudio = estudio.GetDireccion();
                string atributos_estudio = (nombre_estudio + " , " + direccion_estudio);
                buscador.Add(atributos_estudio);

            }
            return buscador;

        }
        

        public void AgregarPersona(Persona persona)
        {
            listaPersonas.Add(persona);
        }

        public void AgregarPelicula(Pelicula pelicula)
        {
            listaPeliculas.Add(pelicula);
        }

        public void AgregarEstudio(Estudio estudio)
        {
            listaEstudios.Add(estudio);
        }
    }
}
