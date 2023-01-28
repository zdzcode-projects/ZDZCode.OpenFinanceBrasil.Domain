using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AccountsTermsConditions
    {
        /// <summary>
        /// Saldo mínimo exigido nos Termos e condições contratuais, que regem as contas comercializadas.
        /// </summary>
        [Required]
        public MinimumBalance MinimumBalance { get; set; }

        /// <summary>
        /// Critérios de qualificação do cliente com a finalidade de definir sua elegibilidade para a aquisição do tipo de conta. Campo Aberto
        /// </summary>
        [Required]
        public string ElegibilityCriteriaInfo { get; set; }

        /// <summary>
        /// Procedimentos de encerramento para o tipo de conta tratado. Possibilidade de inscrição da URL. Endereço eletrônico de acesso ao canal. p.ex. 'https://example.com/mobile-banking'
        /// </summary>
        [Required]
        public string ClosingProcessInfo { get; set; }
    }
}
