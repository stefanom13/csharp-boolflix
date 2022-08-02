using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Profilo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NomeProfilo { get; set; }    
        public bool Bambino { get; set; }

        //1 M
        public List<PlayList> PlayLists { get; set; }

        // M M
        public List<ContenutoVideo> ContenutoVideos { get; set; }

    }
}
