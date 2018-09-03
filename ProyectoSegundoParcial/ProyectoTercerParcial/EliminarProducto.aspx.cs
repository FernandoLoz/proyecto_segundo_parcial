using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTercerParcial
{
    public partial class EliminarProducto : System.Web.UI.Page
    {
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=p2; Uid=root; pwd=1288;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM p2.productos WHERE idProductos = '" + txtIdProducto.Text + " ' ";
                conectar.Open();
                MySqlCommand comando = new MySqlCommand(deleteQuery, conectar);


                if (comando.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script>alert('Producto Eliminado');</script>");
                }
                else
                {
                    Response.Write("<script>alert('No se elimino al producto, por favor valide con el administrador');</script>");
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