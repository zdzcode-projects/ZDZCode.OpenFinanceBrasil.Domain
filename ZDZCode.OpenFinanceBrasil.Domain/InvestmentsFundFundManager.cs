using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFundFundManager
    {
        /// <summary>
        /// Pessoa natural ou jurídica responsável pela gestão profissional dos ativos da carteira de valores mobiliários autorizado pela CVM.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// CNPJ do gestor do fundo de investimento.
        /// </summary>
        [Required]
        public string CnpjNumber { get; set; }
    }
}
