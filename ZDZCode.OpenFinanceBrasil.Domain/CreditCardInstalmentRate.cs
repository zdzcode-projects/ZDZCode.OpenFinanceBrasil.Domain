using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class CreditCardInstalmentRate
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
        public string Rate { get; set; }

        /// <summary>
        /// Lista distribuição preços tarifas de serviços
        /// </summary>
        [Required]
        public List<Application> Applications { get; set; }

        /// <summary>
        /// Percentual mínimo cobrado para a taxa do crédito rotativo no mês de referência.
        /// </summary>
        [Required]
        public string MinimumRate { get; set; }

        /// <summary>
        /// Percentual máximo cobrado para o pagamento parcelado do saldo devedor na fatura do mês de referência.
        /// </summary>
        [Required]
        public string MaximumRate { get; set; }
    }
}
