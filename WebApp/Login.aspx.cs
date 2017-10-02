using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string url = string.Format("{0}?username={1}&password={2}",
                "Home.aspx", txtPassword.Text, txtUsername.Text);
                //MiPersona.ObtenerNombre());

            Server.Transfer(url);
        }
    }
}