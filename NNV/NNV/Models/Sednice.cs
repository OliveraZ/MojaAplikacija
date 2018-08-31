using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NNV.Models
{
    [Table(name:"Sednice")]
    public class Sednice
    {
        [Key]
        public int ID_Sednice { get; set; }
        public DateTime Datum { get; set; }
        public string Vrsta_sednice { get; set; }
        public string Ucionica { get; set; }
        public string Zapisnik { get; set; }
        public string Poziv { get; set; }
        public virtual ICollection<Prilozi> Prilozi { get; set; }
    }
}