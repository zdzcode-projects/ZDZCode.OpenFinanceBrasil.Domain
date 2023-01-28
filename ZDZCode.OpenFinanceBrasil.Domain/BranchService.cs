using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BranchService
    {
        /// <summary>
        /// Nome dos Serviços efetivamente prestados pelo Canal de Atendimento, discriminados na Seção 4.2 da Resolução nº 35, BCB, 2020.
        /// </summary>
        [Required]
        public EnumBranchServicesNames Name { get; set; }

        /// <summary>
        /// Código dos Serviços efetivamente prestados pelo Canal de Atendimento.
        /// </summary>
        [Required]
        public EnumBranchServicesCodes Code { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao Serviço disponível, quando for selecionada a opção 'OUTROS_PRODUTOS_SERVICOS'.
        /// </summary>
        public string AdditionalInfo { get; set; }
    }
}
