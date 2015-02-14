using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Data.Infrastructures
{
    public interface IDatabaseFactory : IDisposable { 
        CrowdsourcingContext Get();     
    }
}
