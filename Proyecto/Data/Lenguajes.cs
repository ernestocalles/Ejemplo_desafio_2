using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Data
{
    public class Lenguajes
    {
        public string nombre { get; set; }
        public string desarrollador { get; set; }
        public string extensiones { get; set; }
        public string aparecio { get; set; }
        public string sistema { get; set; }
        public string paragdima { get; set; }
        public string ultimaversion { get; set; }
        public string licencia { get; set; }

        public int porcentaje { get; set; }

        public Lenguajes(string nom, string desa, string ext, string apa, string so, string para, string uv, string lic, int por) {
            nombre = nom;
            desarrollador = desa;
            extensiones = ext;
            aparecio = apa;
            sistema = so;
            paragdima = para;
            ultimaversion = uv;
            licencia = lic;
            porcentaje = por;
        }
    }
}
