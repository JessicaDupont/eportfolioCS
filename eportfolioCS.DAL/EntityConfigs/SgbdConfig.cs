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
    public class SgbdConfig : IEntityTypeConfiguration<SgbdEntity>
    {
        public void Configure(EntityTypeBuilder<SgbdEntity> builder)
        {
            //TODO nom unique
        }
    }
}
