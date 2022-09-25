using eportfolioCS.DAL.Entities;
using eportfolioCS.DAL.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;

namespace eportfolioCS.DAL
{
    public class DataContext : DbContext
    {
        private readonly string _connectToDBString = "";//TODO recupérer la chaine de connexion à la DB
        
        /*les entités
         elles seront accessibles par le projet appelant
         */
        public DbSet<TexteEntity> Textes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) 
        {
            //TODO optionBuilder.UseSqlServer(_connectToDBString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TexteConfig());
        }
    }
}
