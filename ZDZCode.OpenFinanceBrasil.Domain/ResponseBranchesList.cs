using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseBranchesList
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public Data data { get; set; }

        /// <summary>
        /// Organização controladora do grupo de instituições financeiras.
        /// </summary>
        [Required]
        public BranchesBrand brand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public LinksPaginated links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public MetaPaginated meta { get; set; }
    }
}
