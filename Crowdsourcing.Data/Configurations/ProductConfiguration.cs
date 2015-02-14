using Crowdsourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Data.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(m => m.Description);
            Property(m => m.Name).IsRequired();

            HasOptional(manager => manager.Manager).WithMany(product => product.Products).HasForeignKey(manager => manager.ManagerId).WillCascadeOnDelete(false);
        }
    }

}
