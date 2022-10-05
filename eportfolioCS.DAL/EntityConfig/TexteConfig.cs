using eportfolioCS.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioCS.DAL.EntityConfig
{
    /*
     * fluent API
     */
    public class TexteConfig : IEntityTypeConfiguration<TexteEntity>
    {
        public void Configure(EntityTypeBuilder<TexteEntity> builder)
        {
            ////clé primaire
            //builder.HasKey(e => e.ID);
            ////clé étrangère
            //builder.HasOne(e => e.TexteSuivant)
            //    .WithOne(e => e.TextePrecedent);
            ////champs
            //builder.Property(e => e.Contenu)
            //    .IsRequired();
            //builder.Property(e => e.Position);
            //builder.Property(e => e.PieceJointe);
        }
    }
}
