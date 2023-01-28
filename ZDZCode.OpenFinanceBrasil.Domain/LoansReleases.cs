using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoansReleases
    {

        /// <summary>
        /// Identificador de pagamento de responsabilidade de cada Instituição transmissora.
        /// </summary>
        public string PaymentId { get; set; }

        /// <summary>
        /// Identifica se é um pagamento pactuado (false) ou avulso (true).
        /// </summary>
        [Required]
        public bool IsOverParcelPayment { get; set; }

        /// <summary>
        /// Identificador de parcela, de responsabilidade de cada Instituição transmissora.
        /// </summary>
        [Required]
        public string InstalmentId { get; set; }

        /// <summary>
        /// Data efetiva do pagamento referente ao contrato da modalidade de crédito consultada, conforme especificação RFC-3339. p.ex. 2014-03-19
        /// </summary>
        [Required]
        public string PaidDate { get; set; }

        /// <summary>
        /// Moeda referente ao valor monetário informado, segundo modelo ISO-4217. p.ex. 'BRL'. Todos os valores monetários informados estão representados com a moeda vigente do Brasil.
        /// </summary>
        [Required]
        public string Currency { get; set; }

        /// <summary>
        /// Valor do pagamento referente ao contrato da modalidade de crédito consultada. Expresso em valor monetário com até 4 casas decimais.
        /// </summary>
        [Required]
        public double PaidAmount { get; set; }

        /// <summary>
        /// Objeto das tarifas e encargos que foram pagos fora da parcela.
        /// </summary>
        [Required]
        public OverParcel overParcel { get; set; }
    }
}
