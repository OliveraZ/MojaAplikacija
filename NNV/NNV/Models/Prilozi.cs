using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NNV.Models
{
    [Table(name:"Prilozi")]
    public class Prilozi
    {
        [Key, Column(Order = 0)]
        public int ID_Sednice { get; set; }

        [Key, Column(Order = 1)]
        public int Rbr_Priloga { get; set; }
        public int ID_Dokumenta { get; set; }
        public string Putanja { get; set; }
        public bool Poslato { get; set; }
        public DateTime DatumSlanja { get; set; }
        public virtual Sednice Sednice { get; set; }
    }
}