using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U4_W3_P
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = Negozio.ListaProdotti;
            Repeater1.DataBind();
        }

    }
    public class Prodotto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Immagine { get; set; }
        public double Prezzo { get; set; }
        public string Descrizione { get; set; }

        public Prodotto(int id, string nome, string immagine, double prezzo, string descrizione)
        {
            ID = id;
            Nome = nome;
            Immagine = immagine;
            Prezzo = prezzo;
            Descrizione = descrizione;
        }
    }

        public static class Negozio
        {
            public static List<Prodotto> ListaProdotti = new List<Prodotto>()
            {
            new Prodotto(0, "Paris Saint-Germain, Home Shirt","https://calcioitalia.com/media/cache/sylius_shop_product_large_thumbnail/52/1f/43381fcea3d9f3c5fd34b99f8302.jpeg", 94, "Maglia, con tema di colore a prevalenza blu, sfoggia una grafica decentrata rossa che passa gradatamente al blu, imitando il modo in cui le iconiche luci di Parigi si fondono nel cielo notturno."),
            new Prodotto(1, "Juventus Football Club, Third Shirt", "https://www.emmecisport.com/large/catalogo/adidas_maglia_juve_3_dp0455_antracite_giallo_.jpg", 99, "Unendo tecnologia e design eco-innovativo, interpreta l'impegno per l'ambiente in stile Juventus: essere sempre i primi a raccogliere nuove sfide e raggiungere nuovi traguardi."),
            new Prodotto(2, "Liverpool Football Club, Away Shirt", "https://calcioitalia.com/media/cache/sylius_shop_product_large_thumbnail/20/32/a6e8ac343b96678759789a9f0474.jpeg", 95, "Ispirata alla divisa lanciata nel 1995. La grafica verde aggiunge un tocco moderno, mentre l'interno rende omaggio alle 97 persone tragicamente scomparse nel disastro di Hillsborough."),
            new Prodotto(3, "Real Madrid Club de Fútbol, Home Shirt", "https://www.merchandisingplaza.com/428350/2/Maglie-2021-22-Real-Madrid-Maglia-2021-22-Real-Madrid-Home-l.jpg", 100, "È ispirata alla Plaza de Cibeles, luogo in cui i tifosi e i giocatori del Real Madrid celebrano le vittorie e i loro titoli. Il colore principale è ovviamente il bianco con loghi in arancione."),
            new Prodotto(4, "Chelsea Football Club, Home Shirt", "https://calcioitalia.com/media/cache/sylius_shop_product_large_thumbnail/81/f0/d7ba742b47fce080f0ae2060d803.jpeg", 89, "Chelsea Home porta il glamour di King's Road in campo grazie alla base blu all-over e ai lussuosi dettagli dorati. All'interno, il design di London Chelsea FC rivela il tuo orgoglio per la squadra."),
            new Prodotto(5, "France, First Shirt", "https://calcioitalia.com/media/cache/sylius_shop_product_large_thumbnail/6c/1d/3d656e91217636703d1d3df7860b.jpeg", 85, "Questo modello replica i dettagli del design originale su un tessuto traspirante, per un look da partita ispirato alla tua squadra del cuore. Il design riprende quello indossato dai professionisti in campo."),
            new Prodotto(6, "Netherlands, First Shirt", "https://www.sportit.com/ir/195307/full/maglia-calcio-paesi-bassi-mondiali-2022-23.jpg", 93, "Da sempre il colore predominante nelle prime divise dell'Olanda è l'arancione, che di anno in anno ha assunto diverse gradazioni, accompagnato dalle rifiniture variabili tra il nero, più ricorrente, e il bianco."),
            new Prodotto(7, "Italy, First Shirt", "https://contents.mediadecathlon.com/p2362320/k$00f8051908e528291b14776ef84690b7/sq/maglie-calcio-nazionali.jpg?format=auto&f=800x0", 86, "PUMA celebra l'eredità delle maglie azzurre dell’Italia e del suo calcio entusiasmante. Con accenti dorati, font retrò e orgogliosi riferimenti ai trionfi e all'iconografia dello stile delle maglie e del bel calcio."),
            new Prodotto(8, "Borussia Dortmund, Third Shirt", "https://www.ferrarisport.it/wp-content/uploads/2017/12/puma__pum-765885-01__imagefront.jpg", 86, "Maglia replica Borussia Dortmund Cup 22/23 –\r\n\r\nIl nero e il giallo non invecchiano mai. La maglia è ispirata alla finale di coppa del 1989, quando il BVB vinse il suo secondo titolo nella competizione.")
            };

            public static List<Prodotto> ListaCarrello { get; set; } = new List<Prodotto>();
        } 
}