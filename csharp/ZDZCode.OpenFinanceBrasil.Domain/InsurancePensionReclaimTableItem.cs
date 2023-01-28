using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InsurancePensionReclaimTableItem
    {
        /// <summary>
        ///
        /// </summary>
        public int InitialMonthRange { get; set; }

        /// <summary>
        ///
        /// </summary>
        public int FinalMonthRange { get; set; }

        /// <summary>
        /// Percentual de faixa de resgate.
        /// </summary>
        public string Percentage { get; set; }
    }
}
