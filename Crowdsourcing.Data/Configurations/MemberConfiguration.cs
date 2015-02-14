using Crowdsourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Data.Configurations
{
    public class MemberConfiguration : EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
        {
            Property(m => m.Name).HasMaxLength(25).IsRequired();
            Property(m => m.PhoneNumber);
            Property(m => m.Age);
            Property(m => m.BirthDate);
            Property(m => m.Password).IsRequired();
            Property(m => m.SubscriptionDate);
            Property(m => m.Email).IsRequired();
            Property(m => m.Pseudo).IsRequired();

            HasOptional(manager => manager.Manager).WithMany(member => member.Members).HasForeignKey(manager => manager.ManagerId).WillCascadeOnDelete(false);

        }
    }

}
