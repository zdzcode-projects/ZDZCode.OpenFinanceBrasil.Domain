using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ErrorMetrics //confirmar com o Zids, classe vazia no site.
    {
        
        public int CurrentDay { get; set; }

        public List<int> PreviousDays { get; set; }
    }
}
