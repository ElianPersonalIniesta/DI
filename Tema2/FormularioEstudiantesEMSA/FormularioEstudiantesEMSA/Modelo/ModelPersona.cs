using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioEstudiantesEMSA.Modelo
{
    public class ModelPersona
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public ModelPersona(string id,string nombre, string apellido)
        {
            Nombre = nombre; Apellidos = apellido;this.id = id;

        }
    }
}
