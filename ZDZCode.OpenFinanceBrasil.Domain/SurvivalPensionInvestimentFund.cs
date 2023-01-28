using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SurvivalPensionInvestimentFund
    {
        /// <summary>   
        /// O CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara.
        /// </summary>
        public CnpjNumber CnpjNumber { get; set; }

        /// <summary>
        /// Lista com as informações do(s) Fundo(s) de Investimento(s) disponíveis para o período de diferimento/acumulação, contemplando:
        /// - Nome Fantasia
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Lista com as informações do(s) Fundo(s) de Investimento(s) disponíveis para o período de diferimento/acumulação, contemplando:
        /// - Taxa Máxima de Administração - em %
        /// </summary>
        public string MaximumAdministrationFee { get; set; }

        /// <summary>
        /// Lista com as informações do(s) Fundo(s) de Investimento(s) disponíveis para o período de diferimento/acumulação, contemplando:
        /// - Tipo de taxa de performance
        /// </summary>
        public string TypePerformanceFee { get; set; }

        /// <summary>
        /// Lista com as informações do(s) Fundo(s) de Investimento(s) disponíveis para o período de diferimento/acumulação, contemplando:
        /// - Taxa Máxima de Performance - em %
        /// </summary>
        public string MaximumPerformanceFee { get; set; }

        /// <summary>
        /// Lista com as informações do(s) Fundo(s) de Investimento(s) disponíveis para o período de diferimento/acumulação, contemplando:
        /// - Regra de Elegibilidade
        /// </summary>
        public bool EligibilityRule { get; set; }

        /// <summary>
        /// Lista com as informações do(s) Fundo(s) de Investimento(s) disponíveis para o período de diferimento/acumulação, contemplando:
        /// - Valor Mínimo de Contribuição
        /// </summary>
        public string MinimumContributionAmount { get; set; }

        /// <summary>
        /// Lista com as informações do(s) Fundo(s) de Investimento(s) disponíveis para o período de diferimento/acumulação, contemplando:
        /// - Valor Mínimo do Saldo Provisão matemática
        /// </summary>
        public string MinimumMathematicalProvisionAmount { get; set; }

        /// <summary>
        /// Moeda referente ao valor monetário, seguindo o modelo ISO-4217.
        /// </summary>
        public CurrencyCode Currency { get; set; }
    }
}
