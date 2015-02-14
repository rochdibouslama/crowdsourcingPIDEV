using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crowdsourcing.Domain.Entities;

namespace Crowdsourcing.Data.Configurations
{
    public class TemplateConfiguration : EntityTypeConfiguration<Template>
    {
        public TemplateConfiguration()
        {
            ToTable("Templates");
            HasKey(m => m.ManagerId);
            Property(m => m.ProjectName).HasMaxLength(25).IsRequired();
        }
    }

}
