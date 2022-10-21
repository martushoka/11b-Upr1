using Microsoft.EntityFrameworkCore;
using MusicHub1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub1.Data
{
   public  class MusicHub1Context:DbContext
    {
        public MusicHub1Context() { }

        public MusicHub1Context(DbContextOptions options)
            : base(options) { }

        public DbSet <Album> Albums { get; set; }

        public DbSet<Performer> Performers { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<SongPerformer> SongPerformers { get; set; }

        public DbSet<Writer> Writers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
                   
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongPerformer>().HasKey(x => new { x.SongId, x.PerformerId });
        }
    }
}
