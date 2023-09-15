using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U4_W3_P
{
    public partial class Dettaglio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idProdotto = Request.QueryString["IDProdotto"];

            int indiceProdotto = int.Parse(idProdotto);
            Image1.ImageUrl = Negozio.ListaProdotti[indiceProdotto].Immagine.ToString();
            NomeProdotto.InnerHtml = Negozio.ListaProdotti[indiceProdotto].Nome.ToString();
            Descrizione.InnerHtml = Negozio.ListaProdotti[indiceProdotto].Descrizione.ToString();
            Prezzo.InnerHtml = Negozio.ListaProdotti[indiceProdotto].Prezzo.ToString("C");
        }

        public static List<Prodotto> Carrello = new List<Prodotto>();

        protected void Carrello_Click(object sender, EventArgs e)
        {
            string idProdotto = Request.QueryString["IdProdotto"];
            int indiceProdotto = int.Parse(idProdotto);

            Negozio.ListaCarrello.Add(Negozio.ListaProdotti[indiceProdotto]);

            messaggio.InnerText = "Maglia aggiunta al carrello";
            messaggio.Style.Add("display", "block");

            ScriptManager.RegisterStartupScript(this, GetType(), "HideMessage", "setTimeout(function() { document.getElementById('" + messaggio.ClientID + "').style.display = 'none'; }, 1000);", true);
        }
    }
}