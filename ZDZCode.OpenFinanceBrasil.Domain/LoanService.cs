using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class LoanService
    {
        /// <summary>
        /// 	Nomes das Tarifas cobradas sobre Serviços relacionados à Modalidade informada do Empréstimo para pessoa natural/jurídica.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Sigla de identificação do serviço relacionado à Modalidade informada de Empréstimo para pessoa natural/jurídica.
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Fatos geradores de cobrança que incidem sobre as Modalidades informada de Empréstimos para pessoa natural/jurídica.
        /// </summary>
        [Required]
        public string ChargingTriggerInfo { get; set; }

        /// <summary>
        /// Lista das Tarifas cobradas sobre Serviços
        /// </summary>
        [Required]
        public Price Prices { get; set; }

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
