using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crowdsourcing.Data.Infrastructures;
using Crowdsourcing.Domain.Entities;

namespace Crowdsourcing.Data.Repositories
{
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        public MemberRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }

    public interface IMemberRepository : IRepository<Member> { }

}
