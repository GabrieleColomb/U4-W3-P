using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U4_W3_P
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater1.DataSource = Negozio.ListaCarrello;
                Repeater1.DataBind();
            }

            double Totale = 0;

            foreach (Prodotto item in Negozio.ListaCarrello)
            { Totale += item.Prezzo; }

            SpesaTotale.InnerText = string.Format("€{0:0.00}", Totale);
        }

        protected void Elimina_Command(object sender, CommandEventArgs e)
        {
            string nomeProdotto = e.CommandArgument.ToString();
            Negozio.ListaCarrello.RemoveAll(prodotto => prodotto.Nome == nomeProdotto);

            Response.Redirect(Request.RawUrl);
        }

        protected void SvuotaBtn_Click(object sender, EventArgs e)
        {
            Negozio.ListaCarrello.Clear();
            Response.Redirect(Request.RawUrl);
        }
    }
}