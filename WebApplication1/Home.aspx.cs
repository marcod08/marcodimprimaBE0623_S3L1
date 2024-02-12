using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nomeCandidato = ConfigurationManager.AppSettings["NomeCandidato"];
            string cognomeCandidato = ConfigurationManager.AppSettings["CognomeCandidato"];

            Label1.Text = $"Nome: {nomeCandidato} || Cognome: {cognomeCandidato}";
        }

    }
}