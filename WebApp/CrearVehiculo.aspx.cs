using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

namespace WebApp
{
    public partial class CrearVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
               LlenarDdl();
            }            
    }

        private void LlenarDdl()
        {
            foreach (var Anio in Enum.GetValues(typeof(Anio)))
            {
                ListItem item = new ListItem(Anio.ToString().Remove(0,1));
                ddlAnio.Items.Add(item);
            }

            foreach (var tipo in Enum.GetValues(typeof(TipoVehiculo)))
            {
                ListItem item = new ListItem(tipo.ToString());
                ddlTipo.Items.Add(item);
            }

            foreach (var color in Enum.GetValues(typeof(Color)))
            {
                ListItem item = new ListItem(color.ToString());
                ddlColor.Items.Add(item);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Vehiculo v = new Vehiculo();

            Boolean exito = false;
            if (Session["listaVehiculos"] == null)
            {
                TipoVehiculo tipo = TipoVehiculo.Auto;
                Color color = Color.Azul;
                v.Año = ddlAnio.SelectedItem.ToString();
                Enum.TryParse(ddlTipo.SelectedItem.Text, out tipo);
                v.Tipo = tipo;
                Enum.TryParse(ddlColor.Text, out color);
                v.Color = color;
                v.Precio = int.Parse(txtPrecio.Text);
                v.Id = (contar()+1).ToString();
                List<Vehiculo> lista = new List<Vehiculo>();
                lista.Add(v);

                Session["listaVehiculos"] = lista;
                exito = true;
            } else
            {
                TipoVehiculo tipo = TipoVehiculo.Auto;
                List<Vehiculo> lista = (List<Vehiculo>)Session["listaVehiculos"];
                v.Año = ddlAnio.SelectedItem.ToString();
                Enum.TryParse(ddlTipo.SelectedItem.Text, out tipo);
                v.Tipo = tipo;
                v.Precio = int.Parse(txtPrecio.Text);
                v.Id = (contar() + 1).ToString();
                lista.Add(v);
                Session["listaVehiculos"] = lista;
                exito = true;
            }

            if (exito)
            {
                lblCantidad.Text = "Exito!, se ha agregado exitosamente un vehiculo/moto con ID "+v.Id;
            }
            else
            {
                lblCantidad.Text = "Falló";
            }

            vaciarControles();
            contar();

        }

        private void vaciarControles()
        {
            txtPrecio.Text = "";
            ddlAnio.SelectedIndex = 0;
            ddlColor.SelectedIndex = 0;
            ddlTipo.SelectedIndex = 0;
        }

        protected int contar()
        {
            if (Session["listaVehiculos"] != null)
            {
                List<Vehiculo> lista = (List<Vehiculo>)Session["listaVehiculos"];
                return lista.Count;
            }
            return 0;

        }
    }
}