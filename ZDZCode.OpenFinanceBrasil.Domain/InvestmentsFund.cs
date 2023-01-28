using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFund
    {
        /// <summary>
        /// Conjunto de informações relativas ao participante do produto de open banking
        /// </summary>
        [Required]
        public Participant Participant { get; set; }

        /// <summary>
        /// Nome oficial do fundo de investimento.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// CNPJ do fundo de investimento.
        /// </summary>
        [Required]
        public string CnpjNumber { get; set; }

        /// <summary>
        /// Código universal que identifica cada valor mobiliário ou instrumento financeiro, conforme Norma ISO 6166.
        /// DEFINIÇÃO:O ISIN (International Securities Identification Number) é um código que identifica um valor mobiliário, conforme a norma ISO 6166.
        /// ESTRUTURA
        /// O ISIN é um código alfanumérico que possui 12 caracteres com a seguinte estrutura:
        /// um prefixo, composto de 2 caracteres alfa, que identifica o código do país(Norma ISO 3166);
        /// o número básico, composto de 9 caracteres alfabéticos ou numéricos em sua extensão;
        /// um dígito numérico de controle.
        /// </summary>
        public string IsinCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public InvestmentsFundAdmin Admin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InvestmentsFundFundManager FundManager { get; set; }

        /// <summary>
        /// Conforme classificação ANBIMA, que segue a deliberação 77 da ANBIMA.
        /// Renda Fixa
        /// Ações
        /// Multimercado
        /// Cambial
        /// </summary>
        [Required]
        public EnumInvestmentsFundProductAnbimaCategory AnbimaCategory { get; set; }

        /// <summary>
        ///
        /// </summary>
        public InvestmentsFundFees Fees { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InvestmentsFundGeneralConditions GeneralConditions { get; set; }

        /// <summary>
        /// Indica o tipo de tributação, podendo ser:
        /// Curto prazo
        /// Longo prazo
        /// Variável
        /// </summary>
        [Required]
        public EnumInvestmentsFundTaxation Taxation { get; set; }
    }
}
