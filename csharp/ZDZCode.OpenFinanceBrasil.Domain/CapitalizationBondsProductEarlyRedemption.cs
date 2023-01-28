using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CapitalizationBondsProductEarlyRedemption
    {
        /// <summary>
        /// Parcela relativa ao Resgate Antecipado
        /// </summary>
        [Required]
        public int Quota { get; set; }

        /// <summary>
        /// Taxa relativa ao Resgate Antecipado
        /// </summary>
        [Required]
        public double Rate { get; set; }
    }
}
