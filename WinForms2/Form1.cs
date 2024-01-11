using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtElemento.Text;
            lwElementos.Items.Add(elem);

            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColor.Items.Add("Rojo");
            cbColor.Items.Add("Verde");
            cbColor.Items.Add("Azul");
            cbColor.Items.Add("Lila");
            cbColor.Items.Add("Rosa");
        }

        private void btVerPerfil_Click(object sender, EventArgs e)
        {
            string Nombre = txtElemento.Text;
            DateTime fecha = dtpFecha.Value;
            //operador  ternario. Como un if en una linea
            string chocolate = chbChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string _tipo;
            if (rbtWizard.Checked) { _tipo = "Wizard"; }
            else if (rbtWizard.Checked) { _tipo = "Muggle"; }
            else { _tipo = "Squids"; }
            string colorFav = cbColor.SelectedItem.ToString();
            string numeroFavorito=numFavorito.Value.ToString();
            string mensaje = chocolate + " es " + _tipo + ", su color es: " + colorFav + ", su numero favorito es : " + numeroFavorito;
            MessageBox.Show("Nombre: "+Nombre+ " Fecha: "+fecha+", "+mensaje);


        }
        
        
    }
}

//5. Configuraciones y trucos varios
//Minibox y Maxminibox, se puede poner en false para desactivar sus funciones de minimizar y maximizar la pantalla
//Anchor, Para usar este es para que un cuadro o label o boton o comentario lo que sea, se estirado a la derecha, izquierda, arriba o abajo, segun se desee.
//ShortCutKeys, aca podes hacer que con tal tecla puedas abrir esa funcion. ejemplo abrir: CRtl +1
//Tambien ordenamiento del tabulador, es una opcino en "Ver" de la parte de arriba.
//Tambien vimos un poquito de color, cambiar un poco el boton.

//6. Ventana Contenedoras
//Pusimos a la ventana que seria el padre: isMidConteiner en true.   Gracias a esto es para que las ventanas emergentes, todas se abriran ahi dentro y no afuera.
//Tambien agregamos esto en el boton, que abriria el click a boton perfil perdon:  ventana.MdiParent = this;
//Tambien arreglamos de fomra logica, de que no abra mas ventanas, porque el showialog da un error.(esta en donde pusimos lo anterior).

//7.Tipo de dato DateTime (este es un struct) este tipo de dato, ya no necesitamos una clase fecha ejemplo //cree otro proyecto xd











