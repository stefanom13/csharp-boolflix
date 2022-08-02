using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Stagione
    {
        [Key]
        public int Id { get; set; }
        public int NumeroStagione { get; set; }
        public string TitoloStagione { get; set; }

    }
}
