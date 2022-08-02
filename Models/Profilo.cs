﻿using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Profilo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }    
        public bool Bambino { get; set; }    



    }
}
