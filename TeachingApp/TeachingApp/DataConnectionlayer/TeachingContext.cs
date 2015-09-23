// SYSTEM LINKAGE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TeachingApp.Models;

// NAMESPACE START
namespace TeachingApp.DataConnectionlayer
{
    // DATABASE CONNECTION FOR TEACHINGCONTEXT START
    public class TeachingContext : DbContext
    {
        public TeachingContext() : base("DefaultConnection") { }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<DifferentialText> DifferentialText { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Sentence> Sentence { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Highscore> Highscore { get; set; }
    }
} // NAMESPACE END