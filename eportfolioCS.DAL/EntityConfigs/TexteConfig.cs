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
    public class TexteConfig : IEntityTypeConfiguration<TexteEntity>
    {
        public void Configure(EntityTypeBuilder<TexteEntity> builder)
        {
            builder.Property(e => e.DateInsert)
                .HasDefaultValueSql("GetDate()");
            builder.Property(e => e.DateUpdate)
                .HasDefaultValueSql("GetDate()");
            builder.HasCheckConstraint(
                "Ctexte_update_apres_insert",
                "'Date_update' >= 'Date_insert'");
        }
    }
}
