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
    public class ExperienceConfig : IEntityTypeConfiguration<ExperienceEntity>
    {
        public void Configure(EntityTypeBuilder<ExperienceEntity> builder)
        {
            builder.Property(e => e.DateInsert)
                .HasDefaultValue(DateTime.Now);
            builder.Property(e => e.DateUpdate)
                .HasDefaultValue(DateTime.Now);
            builder.HasCheckConstraint(
                "C_update_apres_insert", 
                "'Date_update' >= 'Date_insert'");
            builder.HasCheckConstraint(
                "C_fin_apres_debut",
                "'Date_fin' >= 'Date_debut'");
        }
    }
}
