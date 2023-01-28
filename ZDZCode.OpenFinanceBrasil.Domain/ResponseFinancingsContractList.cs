using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseFinancingsContractList
    {
        /// <summary>
        /// [Conjunto de informações de contratos de financiamento mantidos pelo cliente na instituição transmissora e para os quais ele tenha fornecido consentimento]
        /// </summary>
        [Required]
        public List<FinancingsListContract> Data { get; set; }

        /// <summary>
        /// Referências para outros recusos da API requisitada.
        /// </summary>
        [Required]
        public Links Links { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Required]
        public Meta Meta { get; set; }
    }
}
