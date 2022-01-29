using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grosu_George.Models
{
    public class FarmacieOras
    {
        public int FarmacieOrasID { get; set; }
        public int ProdusID { get; set; }
        public Produse Produse { get; set; }
        public int FarmaciiID { get; set; }
        public Farmacii Farmacii { get; set; }
    }
}
