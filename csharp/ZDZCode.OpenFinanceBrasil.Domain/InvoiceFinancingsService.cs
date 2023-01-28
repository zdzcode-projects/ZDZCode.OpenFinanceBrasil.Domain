using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class InvoiceFinancingsService
    {
        /// <summary>
        /// Nomes das Tarifas cobradas sobre Serviços ofertados à Modalidade de direitos creditórios descontados. (Campo Livre).
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Sigla de identificação do serviço relacionado à Modalidade de direitos creditórios descontados, para pessoa natural. Campo aberto.
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Fatos geradores de cobrança que incidem sobre as Modalidades de direitos creditórios descontados, para pessoa natural. Campo Livre.
        /// </summary>
        [Required]
        public string ChargingTriggerInfo { get; set; }

        /// <summary>
        /// Lista distribuição preços tarifas de serviços.
        /// </summary>
        [Required]
        public List<Price> Prices { get; set; }

        /// <summary>
        /// Valor mínimo cobrado para a tarifa de serviços sobre a base de clientes no mês de referência.
        /// </summary>
        [Required]
        public MinimumPrice Minimum { get; set; }

        /// <summary>
        /// Valor máximo cobrado para a tarifa de serviços sobre a base de clientes no mês de referência.
        /// </summary>
        [Required]
        public MaximumPrice Maximum { get; set; }
    }
}
