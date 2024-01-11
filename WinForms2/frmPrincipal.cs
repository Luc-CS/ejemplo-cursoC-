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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.OpenForms //aca van a estar todos los formularios que esten abiertos.
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {//gettype devuelve el tipo de objeto, y typeof(form1
                    MessageBox.Show("Ya existe esta ventana, termine de trabajar alli");
                    return;// sale si es asi y no crea otra ventana.
                }
            }
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
           // ventana.ShowDialog();//Este DiaLog Le da prioridad y no deja volver a la ventana anterior
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 ventana2 = new Form1();
            ventana2.ShowDialog();//Este DiaLog Le da prioridad y no deja volver a la ventana anterior
        }
    }
}
