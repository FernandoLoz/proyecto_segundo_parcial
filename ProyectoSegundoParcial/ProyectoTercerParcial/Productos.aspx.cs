using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTercerParcial
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlSeleccionOpcionProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aDondeTeRedirigo = "";
            if (ddlSeleccionOpcionProducto.SelectedIndex > 0)
            {
                switch (ddlSeleccionOpcionProducto.SelectedValue)
                {
                    case "ALTA":
                        aDondeTeRedirigo = "~/AgregarProducto.aspx";
                        break;
                    case "ACTUALIZACION":
                        aDondeTeRedirigo = "~/ActualizarProducto.aspx";
                        break;
                    case "BAJA":
                        aDondeTeRedirigo = "~/EliminarProducto.aspx";
                        break;
                    case "LISTADO":
                        aDondeTeRedirigo = "~/MostrarProductos.aspx";
                        break;
                }
            }
            Response.Redirect(aDondeTeRedirigo);
        }
    }
}