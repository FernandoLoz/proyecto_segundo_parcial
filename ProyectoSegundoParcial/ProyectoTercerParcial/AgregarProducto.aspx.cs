using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTercerParcial
{
    public partial class AgregarProducto : System.Web.UI.Page
    {
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=p2; Uid=root; pwd=1288;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO p2.productos(Nombre,Codigo,PrecioProveedor,PrecioVenta,Proveedores_idProveedores,Cantidad) VALUES('"
                    + txtNombreProducto.Text + "','" + txtCodigo.Text + "','" + txtPrecioProveedor.Text + "','" + txtPrecioVenta.Text + "','" 
                    + txtIdProveedor.Text + "','" + txtCantidad.Text + "')";

                conectar.Open();
                MySqlCommand comando = new MySqlCommand(insertQuery, conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script>alert('Producto Agregado');</script>");
                }
                else
                {
                    Response.Write("<script>alert('No se agrego al producto, por favor valide con el administrador');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            conectar.Close();
        }
    }
}