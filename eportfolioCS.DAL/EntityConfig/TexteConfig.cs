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
    public class TexteConfig : IEntityTypeConfiguration<TexteEntity>
    {
        public void Configure(EntityTypeBuilder<TexteEntity> builder)
        {
            //nom de la table
            //TODO builder.ToTable("Texte");
            //clé primaire
            builder.HasKey(e => e.TexteID);
            //clé étrangère
            builder.HasOne(e => e.TexteActuel)
                .WithOne(e => e.TextePrecedent)
                ;//TODO.HasForeignKey(e => e.TextePrecedentID);
            //champs
            builder.Property(e => e.Contenu)
                .IsRequired();
            builder.Property(e => e.Position);
            builder.Property(e => e.PieceJointe);
        }
    }
}
