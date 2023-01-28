using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFundGeneralConditionsRedemption
    {
        /// <summary>
        /// Prazo em dias indicada no regulamento do fundo para a conversão das cotas em dinheiro.
        /// </summary>
        [Required]
        public int QuotationDays { get; set; }

        /// <summary>
        /// Período em dias corridos ou dias úteis do prazo de cotização.
        /// Dias corridos
        /// Dias úteis
        /// </summary>
        [Required]
        public EnumInvestmentsFundGeneralConditionsTermType QuotationTerm { get; set; }

        /// <summary>
        /// Prazo em dias do efetivo pagamento, pelo fundo, do valor líquido devido ao cotista que efetuou pedido de resgate.
        /// </summary>
        [Required]
        public int PaymentDays { get; set; }

        /// <summary>
        /// Período em dias corridos ou dias úteis do prazo de cotização.
        /// Dias corridos
        /// Dias úteis
        /// </summary>
        [Required]
        public EnumInvestmentsFundGeneralConditionsTermType PaymentTerm { get; set; }

        /// <summary>
        /// Estabelece um período em quantidade de dias corridos em que o investidor não pode resgatar os recursos aplicados no fundo. Caso ocorra resgate antes do período, o investidor perderá a rentabilidade do período. Caso não exista, não informe o campo.
        /// </summary>
        public int GraceDays { get; set; }
    }
}
