using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalFinancingFeeService
    {
        /// <summary>
        /// Nomes das Tarifas cobradas sobre Serviços ofertados à Modalidade de Financiamento.
        /// </summary>
        [Required]
        public string name { get; set; }

        /// <summary>
        /// Sigla de identificação do serviço relacionado à Modalidade de Financiamento informada. Campo Aberto.
        /// </summary>
        [Required]
        public string code { get; set; }

        /// <summary>
        /// Fatos geradores de cobrança que incidem sobre as Modalidades de Financiamentos. Campo Aberto.
        /// </summary>
        [Required]
        public string chargingTriggerInfo { get; set; }

        /// <summary>
        /// Lista distribuição preços tarifas de serviços
        /// </summary>
        [Required]
        public Price prices { get; set; }

        /// <summary>
        /// Valor mínimo cobrado para a tarifa de serviços sobre a base de clientes no mês de referência.
        /// </summary>
        [Required]
        public MinimumPrice minimum { get; set; }

        /// <summary>
        /// Valor máximo cobrado para a tarifa de serviços sobre a base de clientes no mês de referência.
        /// </summary>
        [Required]
        public MaximumPrice maximum { get; set; }
    }
}
