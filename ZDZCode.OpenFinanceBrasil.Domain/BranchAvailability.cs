using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BranchAvailability
    {
        /// <summary>
        /// Lista disponibilidade padrão da depêndencia por dias da semana.
        /// </summary>
        [Required]
        public List<Standard> Standards { get; set; }

        /// <summary>
        /// Em campo texto devem ser registradas todas as Exceções para o não atendimento. p.ex. 'Exceto feriados municipais, nacionais e estaduais'.
        /// </summary>
        [Required]
        public string Exception { get; set; }

        /// <summary>
        /// Indica se a instalação da Dependência tem acesso restrito a clientes, por exemplo. p.ex. 'false' (restrito)
        /// </summary>
        public bool IsPublicAccessAllowed { get; set; }
    }
}
