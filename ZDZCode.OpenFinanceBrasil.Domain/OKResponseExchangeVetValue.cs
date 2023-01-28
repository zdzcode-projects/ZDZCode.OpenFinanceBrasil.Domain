using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class OKResponseExchangeVetValue
    {
        /// <summary>
        /// [Conjunto de informações referentes às informações de câmbio]
        /// </summary>
        [Required]
        public List<ExchangeVetValue> Data { get; set; }

        /// <summary>
        /// Referências para outros recusos da API requisitada.
        /// </summary>
        [Required]
        public Links Links { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Required]
        public Phase4Meta Meta { get; set; }
    }
}
