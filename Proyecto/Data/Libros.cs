using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Data
{
    public class Libros
    {
        public string nombre { get; set; }
        public string autor { get; set; }
        public string genero { get; set; }

        public string subgenero { get; set; }
        public string paginas { get; set; }
        public string protagonistas { get; set; }
        public string antagonistas { get; set; }
        public string argumento { get; set; }
        public int porcentaje { get; set; }


        public Libros(string nom, string au, string gen,string sub ,string pag, string pro, string anta, string argu, int porc) {
            nombre = nom;
            autor = au;
            genero = gen;
            subgenero = sub;
            paginas = pag;
            protagonistas = pro;
            antagonistas = anta;
            argumento = argu;
            porcentaje = porc;
        }

    }
}
