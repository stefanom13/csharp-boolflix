using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Genere
    {
        [Key]
        public int Id { get; set; }
        public string NomeGenere { get; set; }

        // 1 M
        public List<ContenutoVideo> ContenutoVideos { get; set; }

    }
}
