using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoanInterestRate
    {
        /// <summary>
        /// Tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040
        /// </summary>
        [Required]
        public ReferentialRateIndexer ReferentialRateIndexer { get; set; }

        /// <summary>
        /// Percentual que incide sobre a composição das taxas de juros remuneratórios.
        /// </summary>
        [Required]
        public decimal Rate { get; set; }

        /// <summary>
        /// Valor da mediana da taxa de remuneração relativa ao serviço ofertado.
        /// </summary>
        [Required]
        public Application Applications { get; set; }

        /// <summary>
        /// Percentual mínimo cobrado (taxa efetiva) no mês de referência, para o Empréstimo contratado. A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%)
        /// </summary>
        [Required]
        public string MinimumRate { get; set; }

        /// <summary>
        /// Percentual máximo cobrado (taxa efetiva) no mês de referência, para o Empréstimo contratado. A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%)
        /// </summary>
        [Required]
        public string maximumRate { get; set; }
    }
}
