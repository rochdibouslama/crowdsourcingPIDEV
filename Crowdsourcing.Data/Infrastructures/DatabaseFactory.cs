using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Data.Infrastructures
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private CrowdsourcingContext dataContext = null;
        public CrowdsourcingContext Get()
        {
            return dataContext ?? (dataContext = new CrowdsourcingContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
