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
    public class EtablissementConfig : IEntityTypeConfiguration<EtablissementEntity>
    {
        public void Configure(EntityTypeBuilder<EtablissementEntity> builder)
        {
            //TODO nom unique
            builder.Property(e => e.Pays)
                .HasDefaultValue("Belgique");
        }
    }
}
