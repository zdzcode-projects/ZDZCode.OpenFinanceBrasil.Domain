using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgentsService
    {
        /// <summary>
        /// Relação dos Nomes de serviços prestados pelo Correspondente.
        /// </summary>
        [Required]
        public EnumBankingAgentsServicesName Name { get; set; }

        /// <summary>
        /// Relação dos Códigos relativos aos serviços prestados pelo Correspondente.	
        /// </summary>
        [Required]
        public EnumBankingAgentsServicesCode Code { get; set; }

        /// <summary>
        /// Detalhes adicionais sobre os serviços prestados.
        /// </summary>
        public string AdditionalInfo { get; set; }
    }
}
