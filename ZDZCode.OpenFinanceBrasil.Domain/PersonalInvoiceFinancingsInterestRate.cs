using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalInvoiceFinancingsInterestRate
    {
        /// <summary>
        /// Tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040
        /// </summary>
        [Required]
        public ReferentialRateIndexer referentialRateIndexer { get; set; }

        /// <summary>
        /// Percentual que incide sobre a composição das taxas de juros remuneratórios.
        /// </summary>
        [Required]
        public decimal rate { get; set; }

        /// <summary>
        /// Lista das faixas de cobrança da taxa efetiva de remuneração
        /// </summary>
        [Required]
        public Application applications { get; set; }

        /// <summary>
        /// Valor mínimo cobrado para a taxa de remuneração relativa ao serviço ofertado, sobre a base de clientes, no mês de referência
        /// </summary>
        [Required]
        public string minimumRate { get; set; }

        /// <summary>
        /// Valor máximo cobrado para a taxa de remuneração relativa ao serviço ofertado, sobre a base de clientes, no mês de referência
        /// </summary>
        [Required]
        public string maximumRate { get; set; }
    }
}
