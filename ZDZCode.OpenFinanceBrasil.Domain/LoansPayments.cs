using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoansPayments
    {
        /// <summary>
        /// Quantidade total de parcelas pagas do contrato referente à Modalidade de Crédito informada.
        /// </summary>
        [Required]
        public int PaidInstalments { get; set; }

        /// <summary>
        /// Valor necessário para o cliente liquidar a dívida.
        /// </summary>
        [Required]
        public double ContractOutstandingBalance { get; set; }

        /// <summary>
        /// Lista dos pagamentos realizados no período.
        /// </summary>
        [Required]
        public List<LoansReleases> Releases { get; set; }
    }
}
