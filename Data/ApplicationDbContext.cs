using eTicketApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Define the many-many relationships using OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors_Movies>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            }
            );

            //one to many and foreign key for Movie class
            modelBuilder.Entity<Actors_Movies>()
                .HasOne(m => m.Movies)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.MovieId);

            //One to many and foreign key for Actor class
            modelBuilder.Entity<Actors_Movies>()
                .HasOne(a => a.Actors)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(a => a.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        //table name for the models
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actors_Movies> Actors_Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
