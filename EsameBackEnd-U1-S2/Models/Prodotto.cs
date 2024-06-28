using System.ComponentModel.DataAnnotations;

namespace EsameBackEnd_U1_S2.Models
{
    public class Prodotto
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome dell'articolo")]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Prezzo { get; set; }

        [Required]
        [Display(Name = "Descrizione dettagliata")]
        public string Descrizione { get; set; }

        [Required]
        [Display(Name = "Immagine di copertina")]
        public string ImmagineCopertina { get; set; }

        [Display(Name = "Immagine aggiuntiva 1")]
        public string ImmagineAggiuntiva1 { get; set; }

        [Display(Name = "Immagine aggiuntiva 2")]
        public string ImmagineAggiuntiva2 { get; set; }
    }
}

