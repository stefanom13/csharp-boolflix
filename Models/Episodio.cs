using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Episodio
    {
        [Key]
        public  int Id { get; set; }

        public string NomeEpisodio { get; set; }
    }
}
