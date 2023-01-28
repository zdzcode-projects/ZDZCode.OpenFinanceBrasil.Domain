using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgentsAvailability
    {
        /// <summary>
        /// Relação da disponbilidade de atendimento.
        /// </summary>
        [Required]
        public List<BankingAgentsStandard> Standards { get; set; }

        /// <summary>
        /// Em campo texto devem ser registradas todas as Exceções para o não atendimento. p.ex. 'Exceto feriados municipais, nacionais e estaduais'.
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// Indica se a instalação do Correspondente Bancário tem acesso restrito a clientes, por exemplo. p.ex. 'FALSO' (restrito).
        /// </summary>
        public string IsPublicAccessAllowed { get; set; }
    }
}
