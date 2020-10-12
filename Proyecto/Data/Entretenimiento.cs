using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Data
{
    public class Entretenimiento
    {
        public string nombre { get; set; }
        public string tituesp { get; set; }
        public string creadox { get; set; }
        public string protagonistas { get; set; }
        public string pais { get; set; }
        public string temporada { get; set; }
        public string episodios { get; set; }
        public string sinopsis { get; set; }
        public int porcentaje { get; set; }


        public Entretenimiento(string nom, string titu, string por, string actores, string origen, string tempo, string episo, string sinopsi, int porcen) {
            nombre = nom;
            tituesp = titu;
            creadox = por;
            protagonistas = actores;
            pais = origen;
            temporada = tempo;
            episodios = episo;
            sinopsis = sinopsi;
            porcentaje = porcen;

        
        }
    }
}
