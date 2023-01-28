using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseDiscoveryOutagesList //sem descrição no site
    {

        [Required]
        [MinLength(2)]
        public Data Data { get; set; }

        /// <summary>
        /// 	Número de chamadas rejeitadas no dia atual.
        /// </summary>
        [Display(Name = "Número de chamadas rejeitadas no dia atual.")]
        [Required]
        [MinLength(2)]
        public DiscoveryOutage Outages { get; set; }

        [Required]
        [MinLength(2)]
        public LinksPaginated Links { get; set; }

        [Required]
        [MinLength(2)]
        public MetaPaginated Meta { get; set; }

    }
}
