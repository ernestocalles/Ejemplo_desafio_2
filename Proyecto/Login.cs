using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Data;

namespace Proyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        List<Usuario> Usuarios = new List<Usuario>();
        private void Login_Load(object sender, EventArgs e)
        {
            Bienvenida b = new Bienvenida();
            b.ShowDialog();

            Usuario us1 = new Usuario();
            us1.usuario = "ads1";
            us1.clave = "12345";
            us1.categoria = "Libros";
            Usuario us2 = new Usuario();
            us2.usuario = "ads2";
            us2.clave = "12345";
            us2.categoria = "Programas de entretenimiento";
            Usuario us3 = new Usuario();
            us3.usuario = "ads3";
            us3.clave = "12345";
            us3.categoria = "Lenguajes de programacion";
            Usuario us4 = new Usuario();
            us4.usuario = "ads4";
            us4.clave = "12345";
            us4.categoria = "Libros";
            Usuario us5 = new Usuario();
            us5.usuario = "ads5";
            us5.clave = "12345";
            us5.categoria = "Lenguajes de programacion";
            Usuario us6 = new Usuario();
            us1.usuario = "ads6";
            us1.clave = "12345";
            us1.categoria = "Libros";

            Usuarios.Add(us1);
            Usuarios.Add(us2);
            Usuarios.Add(us3);
            Usuarios.Add(us4);
            Usuarios.Add(us5);
            Usuarios.Add(us6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string us, pas, cat = "";
            foreach (var item in Usuarios)
            {
                if (textBox1.Text == item.usuario && textBox2.Text == item.clave)
                {
                    cat = item.categoria;
                }
            }

            if (cat != "")
            {
                Principal p = new Principal(cat);
                p.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no registrado.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
