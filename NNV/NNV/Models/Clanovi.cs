using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NNV.Models
{
    [Table(name:"Clanovi")]
    public class Clanovi
    {
        [Key]
        
        public int ID_Clanovi { get; set; }
        public string Ime_i_prezime { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string E_mail {get; set;}
        public bool Status { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Lozinka { get; set; }
        public virtual ICollection<Prilozi> Prilozi { get; set; }

    }
}