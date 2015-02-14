using Crowdsourcing.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Data.Infrastructures
{
    public interface IUnitOfWork
    {
        void Commit();
        IManagerRepository ManagerRepository { get; }
        IMemberRepository MemberRepository { get; }
        IProductRepository ProductRepository { get; }
        ITemplateRepository TemplateRepository { get; }
    }

}
