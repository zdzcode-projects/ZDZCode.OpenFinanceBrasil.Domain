using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class UnarrangedAccountOverdraftService
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public EnumUnarrangedAccountOverdraftFeeName name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public EnumUnarrangedAccountOverdraftFeeCode code { get; set; }
        /// <summary>
        ///
        /// </summary>
        [Required]
        public string chargingTriggerInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public Price prices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public MinimumPrice minimum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public MaximumPrice maximum { get; set; }
    }
}
