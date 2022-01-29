using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grosu_George.Models
{
    public class Oras
    {
        public int ID { get; set; }

        [Display(Name = "Oras")]
        [Required(ErrorMessage = "Camp obligatoriu.")]
        [MinLength(3, ErrorMessage = "Necesar minim 3 trei caractere.")]
        [MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
        public string orasDen { get; set; }

        public ICollection<Produse> Produse { get; set; } //navigation property
    }
}
