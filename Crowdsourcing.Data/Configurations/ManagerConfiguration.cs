using Crowdsourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Data.Configurations
{
    public class ManagerConfiguration : EntityTypeConfiguration<Manager>
    {
        public ManagerConfiguration()
        {
            ToTable("Managers");

            HasKey(m => m.ManagerId);
            Property(m => m.Name).HasMaxLength(25).IsRequired();
            Property(m => m.PhoneNumber);
            Property(m => m.Age);
            Property(m => m.BirthDate);
            Property(m => m.Password).IsRequired();
            Property(m => m.SubscriptionDate);
            Property(m => m.Email).IsRequired();
            Property(m => m.Pseudo).IsRequired();
            Property(m => m.EnterpriseName).IsRequired();
            Property(m => m.Image);

            HasOptional(t => t.Template).WithRequired(ad => ad.Manager);
        }
    }
}
