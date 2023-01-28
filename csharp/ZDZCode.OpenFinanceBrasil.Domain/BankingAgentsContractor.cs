using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgentsContractor
    {
        /// <summary>
        /// Nome do contratante do serviço do correspondente.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// CNPJ do Contrante.
        /// </summary>
        [Required]
        public string CnpjNumber { get; set; }

        /// <summary>
        /// Lista de correspondentes bancários.
        /// </summary>
        [Required]
        public List<BankingAgent> BankingAgents { get; set; }
    }
}
