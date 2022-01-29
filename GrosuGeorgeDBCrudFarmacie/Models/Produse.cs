using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grosu_George.Models
{
    public class Produse
    {
        public int ID { get; set; }

        [Display(Name = "Nume Produs")]
        [Required(ErrorMessage = "Numele produsului este obligatorie.")]
        [MinLength(3, ErrorMessage = "Necesar minim 3 trei caractere.")]
        [MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
        public string produsNume { get; set; }

        [Display(Name = "Producator")]
        [Required(ErrorMessage = "Numele producatorului este obligatorie.")]
        [MinLength(3, ErrorMessage = "Necesar minim 3 trei caractere.")]
        [MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
        public string produsProd { get; set; }

        [Display(Name = "Data Expirare")]
        [Required(ErrorMessage = "Data expirarii este obligatorie.")]
        [DataType(DataType.Date)]
        public DateTime produsExp { get; set; }

        [Display(Name = "ID Farmacie")]
        [Required(ErrorMessage = "Setati va rog farmacia unde se afla produsul.")]
        public int FarmaciiID { get; set; }
        public Farmacii Farmacie { get; set; }

        [Display(Name = "ID Oras")]
        [Required(ErrorMessage = "Setati va rog orasul unde se afla farmacia.")]
        public int OrasID { get; set; }
        public Oras Oras { get; set; }
    }
}
