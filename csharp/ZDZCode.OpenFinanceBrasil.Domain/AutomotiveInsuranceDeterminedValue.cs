using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AutomotiveInsuranceDeterminedValue
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public ContractBaseDeterminedValue Min { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public ContractBaseDeterminedValue Max { get; set; }
    }
}
