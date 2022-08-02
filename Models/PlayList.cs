using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class PlayList
    {
        [Key]
        public int Id { get; set; }

        public string TitoloPlayList { get; set; }
    }
}
