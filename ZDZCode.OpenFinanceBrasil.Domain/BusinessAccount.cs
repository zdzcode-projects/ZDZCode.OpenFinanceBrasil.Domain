using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BusinessAccount
    {
        /// <summary>
        /// Tipos de contas ofertadas para pessoa natual ou jurídica.
        /// </summary>
        [Required]
        public EnumAccountType Type { get; set; }

        /// <summary>
        /// Objeto que reúne informações de tarifas de serviços.
        /// </summary>
        [Required]
        public FeesBusinessAccount Fees { get; set; }

        /// <summary>
        /// Lista dos serviços que compõe o pacote de serviços.
        /// </summary>
        [Required]
        public List<ServiceBundle> ServiceBundles { get; set; }

        /// <summary>
        /// Lista dos canais para aberturas e encerramento.
        /// </summary>
        [Required]
        public List<EnumOpeningClosingChannels> OpeningClosingChannels { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao Canal disponível, quando no campo ''openingClosingChannels'' estiver preenchida a opção ''Outros''. Restrição: Campo de preenchimento obrigatório se ''openingCloseChannels'' estiver preenchida a opção ''OUTROS''
        /// </summary>
        [Required]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Lista de formas de movimentação.
        /// </summary>
        [Required]
        public List<EnumTransactionMethods> TransactionMethods { get; set; }

        /// <summary>
        /// Objeto que reúne informações relativas a Termos e Condições para as modalidades tratadas.
        /// </summary>
        [Required]
        public AccountsTermsConditions TermsConditions { get; set; }

        /// <summary>
        /// Valores dos percentuais de taxas.
        /// </summary>
        [Required]
        public List<AccountsIncomeRate> IncomeRate { get; set; }
    }
}
