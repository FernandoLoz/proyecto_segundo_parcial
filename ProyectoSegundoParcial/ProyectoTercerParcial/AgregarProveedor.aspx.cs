using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTercerParcial
{
    public partial class AgregarProveedor : System.Web.UI.Page
    {
        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=p2; Uid=root; pwd=1288;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
                try
                {
                    string insertQuery = "INSERT INTO p2.proveedores(Nombre,Direccion,Telefono) VALUES('"
                        + txtNombreProveedor.Text + "','" + txtDireccionProveedor.Text + "','" + txtTelefono.Text + "')";
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand(insertQuery, conectar);

                    if (comando.ExecuteNonQuery() == 1)
                    {
                        Response.Write("<script>alert('Proveedor Agregado');</script>");
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