using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFundGeneralConditionsApplication
    {
        /// <summary>
        /// Indica se o fundo estabelece um período em que o investidor não pode resgatar os recursos aplicados no fundo. Caso ocorra resgate antes do período, o investidor perderá a rentabilidade do período.
        /// </summary>
        [Required]
        public int QuotationDays { get; set; }

        /// <summary>
        /// Período em dias corridos ou dias úteis do prazo de cotização.
        /// Dias corridos
        /// Dias úteis
        /// </summary>
        [Required]
        public string QuotationTerm { get; set; }
    }
}
