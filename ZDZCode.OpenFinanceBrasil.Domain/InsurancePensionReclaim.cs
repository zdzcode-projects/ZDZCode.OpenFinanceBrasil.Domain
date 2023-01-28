using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InsurancePensionReclaim
    {
        /// <summary>
        ///
        /// </summary>
        public List<InsurancePensionReclaimTableItem> Table { get; set; }

        /// <summary>
        ///
        /// </summary>
        public GracePeriod GracePeriod { get; set; }

        /// <summary>
        /// Campo aberto (possibilidade de incluir URL)
        /// </summary>
        public string DifferenciatedPercentage { get; set; }
    }
}
