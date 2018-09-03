using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSegundoParcial
{
    public partial class Form1 : Form
    {
        FormProveedores Frm2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frm2 = new FormProveedores();
            Frm2.MdiParent = this;
            Frm2.Show();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            MessageBox.Show("Conectado");
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores ventanap = new FormProveedores();
            ventanap.MdiParent = this;
            ventanap.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos ventanapr = new Productos();
            ventanapr.MdiParent = this;
            ventanapr.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
