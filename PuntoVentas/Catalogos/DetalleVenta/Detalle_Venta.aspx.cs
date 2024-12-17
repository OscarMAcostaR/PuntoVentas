using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace PuntoVentas.Catalogos.DetalleVenta
{
    public partial class Detalle_Venta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrid();
            }

        }
        private void cargarGrid()
        {
            GVDetVentas.DataSource = BLL_DetVentas.Get_Detalle();
            GVDetVentas.DataBind();
        }

        protected void GVDetVentas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int varIndex = int.Parse(e.CommandArgument.ToString());
                string id = GVDetVentas.DataKeys[varIndex].Values["id_detalle"].ToString();

                Response.Redirect($"Formulario_Rutas.aspx?Id={id}");
            }
        }

        protected void GVDetVentas_RowCommand1(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}