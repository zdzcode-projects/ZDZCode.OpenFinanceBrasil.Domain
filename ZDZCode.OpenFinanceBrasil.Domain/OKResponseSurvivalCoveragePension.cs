using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class OKResponseSurvivalCoveragePension
    {
        public List<GetSurvivalPensionContractData> Data { get; set; }
        public Links Links { get; set; }
        public Phase4Meta Meta { get; set; }
    }
}
