using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
namespace WebApp
{
    public partial class ListarVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            ListaVehiculos();
        }

        protected void ListaVehiculos()
        {
            if (Session["listaVehiculos"] != null)
            {
                List<Vehiculo> listaVehiculos = (List<Vehiculo>)Session["listaVehiculos"];
                foreach (var item in listaVehiculos)
                {
                    lista.DataSource = listaVehiculos;
                    lista.DataBind();

                }
            }


        }
    }
}