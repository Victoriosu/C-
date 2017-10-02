using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
namespace WebApp
{
    public partial class EditarVehiculo : System.Web.UI.Page
    {
        int indice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            txtPrecio.Text = "0";
 
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (Session["listaVehiculos"] != null)
            {
                List<Vehiculo> listaVehiculos = (List<Vehiculo>)Session["listaVehiculos"];
                string codigoAbuscar = txtBuscar.Text;

                Vehiculo encontrado = new Vehiculo();
                int contador = 0;
                foreach (var item in listaVehiculos)
                {
                    if (codigoAbuscar.Equals(item.Id))
                    {
                        encontrado = item;
                        ddlAnio.SelectedValue = encontrado.Año.ToString();
                        ddlColor.SelectedValue = encontrado.Color.ToString();
                        ddlTipo.SelectedValue = encontrado.Tipo.ToString();
                        txtPrecio.Text = encontrado.Precio.ToString();
                        indice = contador;
                        return;
                    } else
                    {
                        contador++;
                    }
                }
            }


        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            if (Session["listaVehiculos"] == null)
            {
                TipoVehiculo tipo = TipoVehiculo.Auto;
                Color color = Color.Azul;
                Vehiculo v = new Vehiculo();
                v.Año = ddlAnio.SelectedItem.ToString();
                Enum.TryParse(ddlTipo.SelectedItem.Text, out tipo);
                v.Tipo = tipo;
                Enum.TryParse(ddlColor.Text, out color);
                v.Color = color;
                v.Precio = int.Parse(txtPrecio.Text);
                List<Vehiculo> lista = new List<Vehiculo>();
                v.Id = (lista.Count() + 1).ToString();
                lista.Add(v);
                lista.RemoveAt(indice);
                lista.Insert(indice, v);
                Session["listaVehiculos"] = lista;
            }
            else
            {
                TipoVehiculo tipo = TipoVehiculo.Auto;
                List<Vehiculo> lista = (List<Vehiculo>)Session["listaVehiculos"];
                Vehiculo v = new Vehiculo();
                v.Año = ddlAnio.SelectedItem.ToString();
                Enum.TryParse(ddlTipo.SelectedItem.Text, out tipo);
                v.Tipo = tipo;
                v.Precio = int.Parse(txtPrecio.Text);
                v.Id = (lista.Count() + 1).ToString();
                lista.RemoveAt(indice);
                lista.Insert(indice, v);
                Session["listaVehiculos"] = lista;
            }

        }
    }
}