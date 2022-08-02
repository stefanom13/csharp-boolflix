using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class ContenutoVideo
    {
        [Key]
        public int Id { get; set; }
        public string Titolo { get; set; }
        public int Durata { get; set; }
        public bool Novità { get; set; }


        // 1 M
       // public List<CronologiaRiproduzione> CronologiaRiproduzione { get; set; }

        // M 1
        public int GenereId { get; set; }
        public Genere Genere { get; set; }

        //M M
        public List<PlayList> PlayLists { get; set; }

        // M M
        public List<Profilo> Profili { get; set; }

        public ContenutoVideo()
        {
        }
    }
}
