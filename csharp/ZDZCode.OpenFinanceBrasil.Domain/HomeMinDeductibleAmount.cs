using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Quantia fixa, definida na apólice, que, em caso de sinistro, representa a parte do prejuízo apurado que poderá deixar de ser paga pela Sociedade Seguradora, dependendo das disposições do contrato. (RESOLUÇÃO CNSP Nº 341/2016). Listagem de valor mínimo da franquia (Reais) estabelecida pela sociedade para cada tipo de cobertura do produto.
    /// </summary>
    public class HomeMinDeductibleAmount
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public string Amount { get; set; }

        /// <summary>
        /// Moeda referente ao valor monetário, seguindo o modelo ISO-4217.
        /// </summary>
        [Required]
        public CurrencyCode Currency { get; set; }
    }
}
