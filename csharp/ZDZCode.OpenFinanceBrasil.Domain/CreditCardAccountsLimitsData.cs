using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardAccountsLimitsData
    {
        /// <summary>
        /// Indicador do tipo de limite.
        /// </summary>
        [Required]
        public EnumCreditCardAccountsLineLimitType CreditLineLimitType { get; set; }

        /// <summary>
        /// Indicador que permite informar se o valor do limite é consolidado ou individual.
        /// </summary>
        [Required]
        public EnumCreditCardAccountsConsolidationType ConsolidationType { get; set; }

        /// <summary>
        /// Número de identificação do cartão: corresponde aos 4 últimos dígitos do cartão para PF, ou então, preencher com um identificador para PJ, com as caracteristicas definidas para os IDs no Open Banking.
        /// </summary>
        [Required]
        public string IdentificationNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        public EnumCreditCardAccountsLineName LineName { get; set; }

        /// <summary>
        /// Campo de preenchimento obrigatório se selecionada a opção 'OUTRAS' em lineName.
        /// </summary>
        public string LineNameAdditionalInfo { get; set; }

        /// <summary>
        /// Indica se a operação de crédito é: com limite flexível (true) ou com limite (false).
        /// </summary>
        [Required]
        public bool IsLimitFlexible { get; set; }

        /// <summary>
        /// Moeda referente ao limite informado, segundo modelo ISO-4217. p.ex. 'BRL.' Todos os limite informados estão representados com a moeda vigente do do Brasil.
        /// </summary>
        [Required]
        public string LimitAmountCurrency { get; set; }

        /// <summary>
        /// Valor total do limite informado Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double LimitAmount { get; set; }

        /// <summary>
        /// Moeda referente ao limite informado, segundo modelo ISO-4217. p.ex. 'BRL.' Todos os saldos informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string UsedAmountCurrency { get; set; }

        /// <summary>
        /// Valor utilizado do limite informado Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double UsedAmount { get; set; }

        /// <summary>
        /// Moeda referente ao limite informado, segundo modelo ISO-4217. p.ex. 'BRL.' Todos os saldos informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string AvailableAmountCurrency { get; set; }

        /// <summary>
        /// Valor disponível do limite informado Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double AvailableAmount { get; set; }
    }
}
