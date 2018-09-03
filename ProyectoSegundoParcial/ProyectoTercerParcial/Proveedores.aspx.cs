using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTercerParcial
{
    public partial class Proveedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlSeleccionOpcionProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aDondeTeRedirigo = "";
            if (ddlSeleccionOpcionProveedores.SelectedIndex > 0)
            {
                switch (ddlSeleccionOpcionProveedores.SelectedValue)
                {
                    case "ALTA":
                        aDondeTeRedirigo = "~/AgregarProveedor.aspx";
                        break;
                    case "ACTUALIZACION":
                        aDondeTeRedirigo = "~/ActualizarProveedor.aspx";
                        break;
                    case "BAJA":
                        aDondeTeRedirigo = "~/EliminarProveedor.aspx";
                        break;
                    case "LISTADO":
                        aDondeTeRedirigo = "~/MostrarProveedores.aspx";
                        break;
                }
            }
            Response.Redirect(aDondeTeRedirigo);
        }
    }
}