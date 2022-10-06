using eportfolioCS.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eportfolioCS.DAL.EntityConfigs
{
    public class ProjetConfig : IEntityTypeConfiguration<ProjetEntity>
    {
        public void Configure(EntityTypeBuilder<ProjetEntity> builder)
        {
            builder.Property(e => e.DateInsert)
                .HasDefaultValueSql("GetDate()");
            builder.Property(e => e.DateUpdate)
                .HasDefaultValueSql("GetDate()");
            builder.HasCheckConstraint(
                "Cprojet_update_apres_insert",
                "'Date_update' >= 'Date_insert'");
            builder.HasCheckConstraint(
                "Cprojet_fin_apres_debut",
                "'Date_fin' >= 'Date_debut'");
            //TODO titre unique
            //TODO url unique
            //TODO giturl unique
        }
    }
}
