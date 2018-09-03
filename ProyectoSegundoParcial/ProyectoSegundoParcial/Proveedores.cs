using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;

namespace ProyectoSegundoParcial
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {

                string insertQuery = "INSERT INTO p2.proveedores(Nombre,Direccion,Telefono) VALUES('" + txtNombre.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "')";
                conectar.Open();
                MySqlCommand comando = new MySqlCommand(insertQuery, conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Agregado");
                }
                else
                {
                    MessageBox.Show("No se pudo Agregar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conectar.Close();

        }


        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=p2; Uid=root; pwd=1288;");

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM p2.proveedores WHERE Nombre = '" + txtNombre.Text + " ' ";
                conectar.Open();
                MySqlCommand comando = new MySqlCommand(deleteQuery, conectar);

                if(comando.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Eliminado");
                }
                else
                {
                    MessageBox.Show("No Eliminado");
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            conectar.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                string updateQuery = "UPDATE p2.proveedores SET Nombre = '" + txtNombre.Text + "', Direccion = '" + txtDireccion.Text + "', Telefono = '" + txtTelefono.Text + "' WHERE IdProveedores = " + int.Parse(txtProveedor.Text) ;
                conectar.Open();
                MySqlCommand comando = new MySqlCommand(updateQuery, conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cambios Guardados");
                }
                else
                {
                    MessageBox.Show("No se Guardaron los Cambios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conectar.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=p2; Uid=root; pwd=1288;");

            MySqlCommand cmd = new MySqlCommand("select * from Proveedores", conectar);
            conectar.Open();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dta = new DataTable();
                sda.Fill(dta);
                BindingSource bdsour = new BindingSource();

                bdsour.DataSource = dta;
                dataGridView1.DataSource = bdsour;
                sda.Update(dta);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = bdsour;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conectar.Close();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            conectar.Open();
            try
            {
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value == null ? "" : cell.Value.ToString());
                    }
                }

                string folderPath = "C:\\Users\\Usuario\\Desktop\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "DatosProveedores.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                }


                MessageBox.Show("El Reporte se Guardo en su Escritorio");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conectar.Close();
        }
    }
}
    