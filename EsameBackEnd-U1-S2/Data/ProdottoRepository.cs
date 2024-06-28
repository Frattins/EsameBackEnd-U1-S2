using EsameBackEnd_U1_S2.Models;

namespace EsameBackEnd_U1_S2.Data
{
    public class ProdottoRepository
    {
        public static List<Prodotto> Prodotti = new List<Prodotto>
        {
            new Prodotto { Id = 1, Nome = "Scarpa Sportiva", Prezzo = 99.99m, Descrizione = "Scarpa comoda per sport", ImmagineCopertina = "copertina1.jpg", ImmagineAggiuntiva1 = "aggiuntiva1_1.jpg", ImmagineAggiuntiva2 = "aggiuntiva1_2.jpg" },
            new Prodotto { Id = 2, Nome = "Scarpa Elegante", Prezzo = 149.99m, Descrizione = "Scarpa elegante per occasioni speciali", ImmagineCopertina = "copertina2.jpg", ImmagineAggiuntiva1 = "aggiuntiva2_1.jpg", ImmagineAggiuntiva2 = "aggiuntiva2_2.jpg" }
        };

        public static List<Prodotto> GetProdotti()
        {
            return Prodotti;
        }

        public static Prodotto GetProdottoById(int id)
        {
            return Prodotti.Find(p => p.Id == id);
        }
    }
}

