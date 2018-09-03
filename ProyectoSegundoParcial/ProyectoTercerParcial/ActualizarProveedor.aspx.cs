using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTercerParcial
{
    public partial class ActualizarProveedor : System.Web.UI.Page
    {
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=p2; Uid=root; pwd=1288;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE p2.proveedores SET Nombre = '" + txtNombreProveedor.Text + "', Direccion = '" + txtDireccionProveedor.Text
                    + "', Telefono = '" + txtTelefono.Text + "' WHERE IdProveedores = " + int.Parse(txtIdProveedor.Text);
                conectar.Open();
                MySqlCommand comando = new MySqlCommand(updateQuery, conectar);

                if (comando.ExecuteNonQuery() == 1)
                {
                    Response.Write("<script>alert('Proveedor Actualizado');</script>");
                }
                else
                {
                    Response.Write("<script>alert('No se agrego al proveedor, por favor valide con el administrador');</script>");
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