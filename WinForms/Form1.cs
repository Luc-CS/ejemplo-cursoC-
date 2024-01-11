using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    //ACA SE VE LA FUNCIONANILIDAD DE LA VENTANA
    public partial class Form1 : Form //FORM ayuda para que esta clase pueda tener una ventana 
    {
        public Form1()//un constructor
        {
            InitializeComponent();//esta funcion, lo que hace inicializar componentes
        }

        //ESTO SERIA UN EVENTO, EL CLIK DEL BOTON OSEA UN SUCESO
        private void button1_Click(object sender, EventArgs e)//cuando se haga clin en el botton: button1
        {
            string texto = comentario.Text;
            label1.Text= "Hola mister "+texto;

           // MessageBox.Show("HOLA MUNDO, SOY LUCAS");
        }

        private void Form1_Load(object sender, EventArgs e)//eSTE evento se ejecuta cuando se carga el formulario, osea solo se ejecut una vez
        {
            MessageBox.Show("Te doy la bienvenida.....");
        }

        //EVENTO AL CERRAR LA APLICACION O LA VENTANA
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por usar la APP");
        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void comentario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //PARTIAL - es como que puedo tener distintos apartardos del mismo codigo
        //o tener clases del mismo nombre por eso el nombre partial, dividia en varias partes.


    }
}
