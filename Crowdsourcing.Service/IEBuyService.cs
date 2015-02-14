using Crowdsourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Service
{
    public interface IEBuyService
    {
        void CreateManager(Manager manager);
        void CreateMember(Member member);
        void CreateProduct(Product product);
        void CreateTemplate(Template template);

        Manager GetManager(int id);
    }

}
