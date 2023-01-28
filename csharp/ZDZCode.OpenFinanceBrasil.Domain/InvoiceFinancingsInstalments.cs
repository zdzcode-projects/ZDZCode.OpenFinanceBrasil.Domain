using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações referentes às parcelas / prestações da operação de crédito contratada.
    /// </summary>
    public class InvoiceFinancingsInstalments
    {
        /// <summary>
        /// Tipo de prazo total do contrato referente à modalidade de crédito informada.
        /// </summary>
        [Required]
        public EnumTypeNumberOfInstalments TypeNumberOfInstalments { get; set; }

        /// <summary>
        /// Prazo Total segundo o tipo (dia, semana, mês, ano) referente à Modalidade de Crédito informada.
        /// </summary>
        [Required]
        public int TotalNumberOfInstalments { get; set; }

        /// <summary>
        /// Tipo de prazo remanescente do contrato referente à modalidade de crédito informada.
        /// </summary>
        [Required]
        public string TypeContractRemaining { get; set; }

        /// <summary>
        /// Prazo Remanescente segundo o tipo (dia, semana, mês, ano) referente à Modalidade de Crédito informada.
        /// </summary>
        [Required]
        public int ContractRemainingNumber { get; set; }

        /// <summary>
        /// Quantidade de prestações pagas. (No caso de modalidades que não possuam parcelas, o número de prestações é igual a zero).
        /// </summary>
        [Required]
        public int PaidInstalments { get; set; }

        /// <summary>
        /// Quantidade de prestações a vencer.(No caso de modalidades que não possuam parcelas, o número de prestações é igual a zero).
        /// </summary>
        [Required]
        public int DueInstalments { get; set; }

        /// <summary>
        /// Quantidade de prestações vencidas. (No caso de modalidades que não possuam parcelas, o número de prestações é igual a zero).
        /// </summary>
        [Required]
        public int PastDueInstalments { get; set; }

        /// <summary>
        /// Lista que traz as datas de vencimento e valor das parcelas não regulares do contrato da modalidade de crédito consultada.
        /// </summary>
        [Required]
        public List<InvoiceFinancingsBalloonPayment> BalloonPayments { get; set; }
    }
}
