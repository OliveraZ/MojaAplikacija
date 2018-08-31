using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NNV.Models
{
    [Table(name:"VrstaDokumenta")]
    public class VrstaDokumenta
    {
        [Key]
        public int ID_Dokumenta { get; set; }
        public string NazivDokumenta { get; set; }
        public virtual ICollection<Prilozi> Prilozi { get; set; }
    }
}