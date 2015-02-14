using Crowdsourcing.Data.Infrastructures;
using Crowdsourcing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Service
{
    public class EBuyService  
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public void CreateManager(Manager manager)
        {
            utOfWork.ManagerRepository.Add(manager);
            utOfWork.Commit();
        }

        public IEnumerable<Manager> GetManagers()
        {
            var managers = utOfWork.ManagerRepository.GetAll();
            return managers;
        }

        void CreateMember(Member member) { }

        void CreateProduct(Product product) { }
        void CreateTemplate(Template template) { }


    }

}
