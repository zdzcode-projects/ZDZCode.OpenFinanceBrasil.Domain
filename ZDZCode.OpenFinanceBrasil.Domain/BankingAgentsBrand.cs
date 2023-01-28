using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgentsBrand
    {
        /// <summary>
        /// Nome da Marca reportada pelo participante do Open Banking. O conceito a que se refere a 'marca' utilizada está em definição pelos participantes.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Lista de instituições pertencentes à marca.
        /// </summary>
        [Required]
        public BankingAgentsCompanies Companies { get; set; }
    }
}
