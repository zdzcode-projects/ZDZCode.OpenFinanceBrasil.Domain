using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseDiscoveryStatusList
    {   //confirmar com o Zids, sem descrição no site
        public Data Data { get; set; }
        public LinksPaginated Links { get; set; }
        public MetaPaginated Meta { get; set; }
    }
}
