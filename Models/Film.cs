using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Film : ContenutoVideo
    {
        [Key]
        public int Id { get; set; }

    }
}
