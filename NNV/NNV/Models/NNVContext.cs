﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace NNV.Models
{
    public class NNVContext : DbContext
    {
        public NNVContext() : base("name=NNV") { }
        public DbSet<Sednice> Sednice { get; set; }
        public DbSet<Prilozi> Prilozi { get; set; }
        public DbSet<VrstaDokumenta> VrstaDokumenta { get; set; }
        public DbSet<Clanovi> Clanovi { get; set; }
    }
}