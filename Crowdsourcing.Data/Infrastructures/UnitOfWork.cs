using Crowdsourcing.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Data.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private CrowdsourcingContext dataContext;
        DatabaseFactory dbFactory;
        public UnitOfWork(DatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        private IManagerRepository managerRepository;
        IManagerRepository IUnitOfWork.ManagerRepository
        {
            get { return managerRepository ?? (managerRepository = new ManagerRepository(dbFactory)); }
        }

        private IMemberRepository memberRepository;
        IMemberRepository IUnitOfWork.MemberRepository
        {
            get { return memberRepository ?? (memberRepository = new MemberRepository(dbFactory)); }
        }

        private IProductRepository productRepository;
        IProductRepository IUnitOfWork.ProductRepository
        {
            get { return productRepository ?? (productRepository = new ProductRepository(dbFactory)); }
        }

        private ITemplateRepository templateRepository;
        ITemplateRepository IUnitOfWork.TemplateRepository
        {
            get { return templateRepository ?? (templateRepository = new TemplateRepository(dbFactory)); }
        }

        protected CrowdsourcingContext DataContext
        {
            get { return dataContext ?? (dataContext = dbFactory.Get()); }
        }

        public void Commit() { DataContext.SaveChanges(); }
    }

}
