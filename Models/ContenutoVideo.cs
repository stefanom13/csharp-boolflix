using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class ContenutoVideo
    {
        [Key]
        public int Id { get; set; }
        public string Titolo { get; set; }
        public int Durata { get; set; }
        public string Novità { get; set; }
    }
}
