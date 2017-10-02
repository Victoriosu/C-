using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
namespace WebApp
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaVehiculos"] != null)
            {
                List<Vehiculo> listaVehiculos = (List<Vehiculo>)Session["listaVehiculos"];
                lista.DataSource = listaVehiculos;
                lista.DataBind();

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Session["listaVehiculos"] != null)
            {
                List<Vehiculo> listaVehiculos = (List<Vehiculo>)Session["listaVehiculos"];
                string codigoAbuscar = txtCodigo.Text;

                Vehiculo encontrado = new Vehiculo();
                foreach (var item in listaVehiculos)
                {
                    if (codigoAbuscar.Equals(item.Id))
                    {
                        encontrado = item;
                        listaVehiculos.Remove(encontrado);
                        lista.DataSource = listaVehiculos;
                        lista.DataBind();
                        return;
                    }
                }
            }
        }
    }
}