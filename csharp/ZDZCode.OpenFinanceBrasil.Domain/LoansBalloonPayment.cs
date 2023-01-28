using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoansBalloonPayment
    {
        /// <summary>
        /// Data de vencimento da parcela não regular a vencer do contrato da modalidade de crédito consultada, conforme especificação RFC-3339. p.ex. 2014-03-19.
        /// </summary>
        [Required]
        public string DueDate { get; set; }

        /// <summary>
        /// Moeda referente ao valor monetário informado, segundo modelo ISO-4217. p.ex. 'BRL' Todos os valores monetários informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Valor monetário da parcela não regular a vencer. Expresso em valor monetário com 4 casas decimais.
        /// </summary>
        [Required]
        public double Amount { get; set; }
    }
}
