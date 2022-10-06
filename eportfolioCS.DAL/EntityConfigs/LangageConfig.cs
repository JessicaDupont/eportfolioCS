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
    public class LangageConfig : IEntityTypeConfiguration<LangageEntity>
    {
        public void Configure(EntityTypeBuilder<LangageEntity> builder)
        {
            //TODO nom unique
        }
    }
}
