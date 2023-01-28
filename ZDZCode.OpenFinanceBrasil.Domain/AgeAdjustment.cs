using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AgeAdjustment
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<string> Criterias { get; set; }

        /// <summary>
        /// Período em anos, caso critério de reenquadramento após ou a cada período em anos.
        /// </summary>
        [Required]
        public int Frequency { get; set; }
    }
}
