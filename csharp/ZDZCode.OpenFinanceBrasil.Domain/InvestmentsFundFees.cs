using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvestmentsFundFees
    {
        /// <summary>
        /// Taxa máxima cobrada para remunerar o administrador e os demais prestadores de serviços do fundo. Caso não haja a difererença de Máximo e Mínimo, considerar a taxa de administração do fundo.
        /// </summary>
        public string MaxAdminFee { get; set; }

        /// <summary>
        /// Taxa cobrada no momento da aplicação, que incide sobre o valor investido no fundo.
        /// </summary>
        public string EntryFee { get; set; }

        /// <summary>
        ///
        /// </summary>
        public InvestmentsFundFeesPerformanceFee PerformanceFee { get; set; }

        /// <summary>
        /// Taxa paga pelo cotista ao resgatar recursos de um fundo.
        /// </summary>
        public string ExitFee { get; set; }
    }
}
