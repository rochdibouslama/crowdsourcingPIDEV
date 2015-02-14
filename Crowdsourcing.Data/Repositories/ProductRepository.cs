using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crowdsourcing.Data.Infrastructures;
using Crowdsourcing.Domain.Entities;

namespace Crowdsourcing.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }
    }

    public interface IProductRepository : IRepository<Product> { }

}
