using Proyecto.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto
{
    public partial class Principal : Form
    {
        string categoria;
        List<Lenguajes> lenguajes = new List<Lenguajes>();
        List<Entretenimiento> entretenimientos= new List<Entretenimiento>();
        List<Libros> libros = new List<Libros>();
        public Principal(string cat)
        {
            categoria = cat;
            InitializeComponent();
            //LLENAMOS LA INFORMACION DEL LAS LISTAS DEPENDIENDO DE LAS CATEGORIAS
            if (categoria == "Lenguajes de programacion")
            {
                Lenguajes L1 = new Lenguajes("PYTHON", "Python Software Foudation", ".py, .pyc, .pyd, .pyo, .pyw, .pyz", "1991", "Multiplataforma",
                    "Multiparadigma: oriendtado a objetos, imperativo, funcional , reflexivo", "3.8.3", "Python Software Foundation License", 47);
                Lenguajes L2 = new Lenguajes("JAVA", "James Gosling y Sun Microsystems", "java,class,jar,jad,jmod", "1996", "Multiplataforma", "Orientado" +
                    " a objetos, imperativo", "14.01", "GNU GPL/ Java community Process", 38);
                Lenguajes L3 = new Lenguajes("JAVASCRIPT", "xx", ".js", "1995", "xx", "Multiparadigma, programacion funcional, programacion basada en prototipos,\n " +
                    "imperativo,interpretado (scripting)", "ECMAScript2016", "xx", 15);
                lenguajes.Add(L1);
                lenguajes.Add(L2);
                lenguajes.Add(L3);

                tabPage1.Text = lenguajes[0].nombre;
                tabPage2.Text = lenguajes[1].nombre;
                tabPage3.Text = lenguajes[2].nombre;
            }
            else if (categoria == "Programas de entretenimiento")
            {
                Entretenimiento E1 = new Entretenimiento("GAME OF THRONES", "Juego de tronos", "David Benioff\nD.B.Weiss", "Sean Bean,  Nikolaj Coster - Waldau, Peter Dinklage\n" +
                    "Emilia Clarke, Lena Headey,Iain Glen,Kit Harington\nSophie Turner,Maisie Williams,Isaac Hempstead - Wright,Natalie Dormer", "Estados unidos", "8", "73", "La trama de Game of Thrones está basada en la serie" +
                    " de novelas Canción de hielo y fuego, y relata \nlas vivencias de un grupo de personajes de distintas casas nobiliarias en el continente ficticio\n Poniente para tener el control del Trono de hierro y gobernar los siete " +
                    "reinos que conforman el territorio", 40);
                Entretenimiento E2 = new Entretenimiento("Chernobyl", "Chernóbil", "Craig Mazin", "Jared Harris\nStellan Skarsgård\nEmily Watson", "Estados Unidos\nReino Unido", "1", "5", "La serie gira en torno al desastre " +
                    "nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin precedentes que\nsiguieron.Cuenta con un reparto encabezado por Jared Harris, Stellan Skarsgård y Emily Watson. ", 34);
                Entretenimiento E3 = new Entretenimiento("THE MARVELOUS MRS. MAISEL", "La maravillosa Señora Maisel ", "Rachel Brosnahan", "Michael Zegen\nAlex Borstein\nTony Shalhoub\nMarin Hinkle ",
                    " Estados Unidos", "3", "26", "La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para\n la comedia en vivo.El primer episodio se estrenó " +
                    "como parte de la temporada de pilotos de primavera de Amazon Studios\n el 17 de marzo de 2017, recibiendo la aclamación de la crítica. ", 26);
                entretenimientos.Add(E1);
                entretenimientos.Add(E2);
                entretenimientos.Add(E3);
                tabPage1.Text = entretenimientos[0].nombre;
                tabPage2.Text = entretenimientos[1].nombre;
                tabPage3.Text = entretenimientos[2].nombre;
            }
            else if (categoria == "Libros") {
                Libros Li1 = new Libros("HARRY POTTER","J. K. Rowling", "Novela", "Literatura fantástica, literatura juvenil, novela de desarrollo \ny literatura infantil yjuvenil","3407 (ENG)\n3665(ESP)", "Harry Potter, Ron weasley, Hermione Granger\nGinny Weasley, Neville Longbottom, Albus Dumbledore", "Lord Voldemort, Mortífagos",
                    "La historia comienza con la celebración del mundo mágico. Durante muchos años, había sido\n aterrorizado por el malvado mago Lord Voldemort.La noche del 31 de octubre,\nmató a Lily y James Potter.Sin embargo, cuando intenta matar a " +
                    "su hijo de 1 año, Harry, la\nmaldición asesina Avada Kedavra se vuelve sobre sí mismo.El cuerpo de Voldemort \nresulta destruido, pero élsobrevive: no está muerto ni vivo.Por su parte, a Harry solo \n" +
                    "le queda una cicatriz con forma de rayo en la frente que es el único remanente físico de la \nmaldición de Voldemort.Harry es el único sobreviviente de la maldición asesina, y a raíz de la \nmisteriosa derrota de Voldemort, el mundo mágico empieza a" +
                    "llamarlo como «el niño que\n sobrevivió». ", 44);

                Libros Li2 = new Libros("GOOSEBUMPS", "Robert Lawrence Stine", "Ciencia ficción, literatura infantil y suspenso","---", "Suspenso, terror, juvenil ", "---", "El protagonista principal de una historia de Pesadillas / Escalofríos, es a menudo situado \nen una ubicación remota o de alguna manera aislada en algunas situaciones",
                    "La serie consta de un total de 60 libros para España, el último de los cuales(Sangre de monstruo\nIV) se publicó en 1999, mientras que en Hispanoamérica consta de 45 historias.\nEl nombre se tradujo en España como Pesadillas y en Hispanoamérica \ncomo Escalofríos. ",30);
                Libros Li3 = new Libros("PERRY MASON", "Erle Stanley Gardner", "Novela policiaca", "xx", "xx", "Perry Mason", "xx", "El personaje era un abogado que llegó a aparecer en 80 novelas e historias cortas, la mayoría de\nlas cuales versaban sobre la defensa de un cliente que había sido acusado de asesinato.En general, Perry Mason era capaz" +
                    "\nde demostrar la inocencia de su cliente mediante la averiguación de la culpabilidad del verdadero\nasesino, otro personaje de la historia.",26);
                libros.Add(Li1);
                libros.Add(Li2);
                libros.Add(Li3);
                tabPage1.Text = libros[0].nombre;
                tabPage2.Text = libros[1].nombre;
                tabPage3.Text = libros[2].nombre;
            }


        }



        private void Principal_Load(object sender, EventArgs e)
        {
            
            
                
            if (categoria == "Lenguajes de programacion")
            {
                label1.Text = lenguajes[0].nombre;
                label2.Text = "Desarrollador: \n" + lenguajes[0].desarrollador + "\nExtensiones: \n" + lenguajes[0].extensiones + "\nAparecion En: \n" + lenguajes[0].aparecio +
                    "\nSistema Operativo: \n" + lenguajes[0].sistema + "\nParadigma: \n" + lenguajes[0].paragdima + "\nUltima Version estable: \n" + lenguajes[0].ultimaversion +
                    "\nLicencia: \n" + lenguajes[0].licencia;

                //CAMBIAR RUTAS DE LAS IMAGENES
                pictureBox1.ImageLocation = "C:\\Users\\HP\\Desktop\\Proyecto\\Proyecto\\Img\\python.png";

                label4.Text = lenguajes[1].nombre;
                label3.Text = "Desarrollador: \n" + lenguajes[1].desarrollador + "\nExtensiones: \n" + lenguajes[1].extensiones + "\nAparecion En: \n" + lenguajes[1].aparecio +
                    "\nSistema Operativo: \n" + lenguajes[1].sistema + "\nParadigma: \n" + lenguajes[1].paragdima + "\nUltima Version estable: \n" + lenguajes[1].ultimaversion +
                    "\nLicencia: \n" + lenguajes[1].licencia;
                //CAMBIAR RUTAS DE LAS IMAGENES
                pictureBox2.ImageLocation = "C:\\Users\\HP\\Desktop\\Proyecto\\Proyecto\\Img\\java.jpeg";

                label6.Text = lenguajes[2].nombre;
                label5.Text = "Desarrollador: \n" + lenguajes[2].desarrollador + "\nExtensiones: \n" + lenguajes[2].extensiones + "\nAparecion En: \n" + lenguajes[2].aparecio +
                    "\nSistema Operativo: \n" + lenguajes[2].sistema + "\nParadigma: \n" + lenguajes[2].paragdima + "\nUltima Version estable: \n" + lenguajes[2].ultimaversion +
                    "\nLicencia: \n" + lenguajes[2].licencia;
                //CAMBIAR RUTAS DE LAS IMAGENES
                pictureBox3.ImageLocation = "C:\\Users\\HP\\Desktop\\Proyecto\\Proyecto\\Img\\javascript.png";

                chart1.Titles.Add("Lenguajes de programacion");

                for (int i=0; i < lenguajes.Count(); i++) {

                    Series series = new Series();
                    series = chart1.Series.Add(lenguajes[i].nombre);

                    series.Label = lenguajes[i].nombre;
                    series.Points.AddXY((i + 1), lenguajes[i].porcentaje);

                }

            }
            else if (categoria == "Programas de entretenimiento") {
                label1.Text = entretenimientos[0].nombre;
                label2.Text = "Titulo en español: \n" + entretenimientos[0].tituesp + "\nCreado por: \n" + entretenimientos[0].creadox+ "\nProtagonistas: \n" + entretenimientos[0].protagonistas+
                    "\nPais de Origen: \n" + entretenimientos[0].pais+ "\nTemporada: \n" + entretenimientos[0].temporada+ "\nEpisodios: \n" + entretenimientos[0].episodios+
                    "\nSinopsis: \n" + entretenimientos[0].sinopsis;
                //CAMBIAR RUTAS DE LAS IMAGENES
                pictureBox1.ImageLocation = "C:\\Users\\HP\\Desktop\\Proyecto\\Proyecto\\Img\\games.jpeg";
                label4.Text = entretenimientos[1].nombre;
                label3.Text = "Titulo en español: \n" + entretenimientos[1].tituesp + "\nCreado por: \n" + entretenimientos[1].creadox+ "\nProtagonistas: \n" + entretenimientos[1].protagonistas+
                    "\nPais de Origen: \n" + entretenimientos[1].pais+ "\nTemporada: \n" + entretenimientos[1].temporada+ "\nEpisodios: \n" + entretenimientos[1].episodios+
                    "\nSinopsis: \n" + entretenimientos[1].sinopsis;
                //CAMBIAR RUTAS DE LAS IMAGENES
                pictureBox2.ImageLocation = "C:\\Users\\HP\\Desktop\\Proyecto\\Proyecto\\Img\\chernobyl.jpg";
                label6.Text = entretenimientos[2].nombre;
                label5.Text = "Titulo en español: \n" + entretenimientos[2].tituesp + "\nCreado por: \n" + entretenimientos[2].creadox+ "\nProtagonistas: \n" + entretenimientos[2].protagonistas+
                    "\nPais de Origen: \n" + entretenimientos[2].pais+ "\nTemporada: \n" + entretenimientos[2].temporada+ "\nEpisodios: \n" + entretenimientos[2].episodios+
                    "\nSinopsis: \n" + entretenimientos[2].sinopsis;
                //CAMBIAR RUTAS DE LAS IMAGENES
                pictureBox3.ImageLocation = "C:\\Users\\HP\\Desktop\\Proyecto\\Proyecto\\Img\\maisel.jpg";
                chart1.Titles.Add("Programas de Entretenimiento");
                for (int i = 0; i < entretenimientos.Count(); i++)
                {

                    Series series = new Series();
                    series = chart1.Series.Add(entretenimientos[i].nombre);

                    series.Label = entretenimientos[i].nombre;
                    series.Points.AddXY((i + 1), entretenimientos[i].porcentaje);
                }

            }
            else if (categoria == "Libros")
            {
                label1.Text = libros[0].nombre;
                label2.Text = "Autor: \n" + libros[0].autor + "\nGenero: \n" + libros[0].genero + "\nSubgenero: \n" + libros[0].subgenero+
                    "\n# Paginas: \n" + libros[0].paginas + "\nProtagonistas: \n" + libros[0].protagonistas+ "\nAntagonistas: \n" + libros[0].antagonistas+
                    "\nArgumento: \n" +libros[0].argumento;
                //CAMBIAR RUTAS DE LAS IMAGENES
                pictureBox1.ImageLocation = "C:\\Users\\HP\\Desktop\\Proyecto\\Proyecto\\Img\\Potter.jpg";
                label4.Text = libros[1].nombre;
                label3.Text = "Autor: \n" + libros[1].autor + "\nGenero: \n" + libros[1].genero + "\nSubgenero: \n" + libros[1].subgenero+
                    "\n# Paginas: \n" + libros[1].paginas + "\nProtagonistas: \n" + libros[1].protagonistas+ "\nAntagonistas: \n" + libros[1].antagonistas+
                    "\nArgumento: \n" +libros[1].argumento;
                //CAMBIAR RUTAS DE LAS IMAGENES
                pictureBox2.ImageLocation = "C:\\Users\\HP\\Desktop\\Proyecto\\Proyecto\\Img\\gosembus.jpg";
                label6.Text = libros[2].nombre;
                label5.Text = "Autor: \n" + libros[2].autor + "\nGenero: \n" + libros[2].genero + "\nSubgenero: \n" + libros[2].subgenero+
                    "\n# Paginas: \n" + libros[2].paginas + "\nProtagonistas: \n" + libros[2].protagonistas+ "\nAntagonistas: \n" + libros[2].antagonistas+
                    "\nArgumento: \n" +libros[2].argumento;
                //CAMBIAR RUTAS DE LAS IMAGENES
                pictureBox3.ImageLocation = "C:\\Users\\HP\\Desktop\\Proyecto\\Proyecto\\Img\\mason.jpg";
                chart1.Titles.Add("Libros");
                for (int i = 0; i < libros.Count(); i++)
                {
                    Series series = new Series();
                    series = chart1.Series.Add(libros[i].nombre);

                    series.Label = libros[i].nombre;
                    series.Points.AddXY((i+1),libros[i].porcentaje);
                    //chart1.Series[libros[i].nombre].Points.AddXY(i,libros[i].porcentaje);

                }

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
