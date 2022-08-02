using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class PlayList
    {
        [Key]
        public int Id { get; set; }

        public string TitoloPlayList { get; set; }


        //M 1 
        public int ProfiloId { get; set; }
        public Profilo Profilo { get; set; }

        //M M
        public List<ContenutoVideo> ContenutoVideos { get; set; }
    }
}
