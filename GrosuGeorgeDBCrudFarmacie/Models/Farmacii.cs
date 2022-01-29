using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grosu_George.Models
{
    public class Farmacii
    {
        public int ID { get; set; }

        [Display(Name = "Denumire Farmacie")]
        [Required(ErrorMessage = "Camp obligatoriu.")]
        [MinLength(3, ErrorMessage = "Necesar minim 3 trei caractere.")]
        [MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
        public string farmacieDen { get; set; }

        [Display(Name = "Adresa Farmacie")]
        [Required(ErrorMessage = "Camp obligatoriu.")]
        [MinLength(3, ErrorMessage = "Necesar minim 3 trei caractere.")]
        [MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
        public string farmacieAdr { get; set; }
        public ICollection<FarmacieOras> FarmacieOras { get; set; }

    }
}
