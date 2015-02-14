using Crowdsourcing.Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crowdsourcing.Domain.Entities;

namespace Crowdsourcing.Data.Repositories
{
    public class TemplateRepository : RepositoryBase<Template>, ITemplateRepository
    {
        public TemplateRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }
    }

    public interface ITemplateRepository : IRepository<Template> { }

}
