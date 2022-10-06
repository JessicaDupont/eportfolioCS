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
    public class FrameworkConfig : IEntityTypeConfiguration<FrameworkEntity>
    {
        public void Configure(EntityTypeBuilder<FrameworkEntity> builder)
        {
            //TODO nom unique
        }
    }
}
