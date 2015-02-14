using Crowdsourcing.Data.Infrastructures;
using Crowdsourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Data.Repositories
{
    class ManagerRepository : RepositoryBase<Manager>, IManagerRepository
    {
        public ManagerRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }

    public interface IManagerRepository : IRepository<Manager> { }

}
