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
    public class FrameworkProjetConfig : IEntityTypeConfiguration<FrameworkProjetEntity>
    {
        public void Configure(EntityTypeBuilder<FrameworkProjetEntity> builder)
        {
            
        }
    }
}
