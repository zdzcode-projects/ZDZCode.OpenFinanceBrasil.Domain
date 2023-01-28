using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BusinessAccountsService
    {
        /// <summary>
        /// Nome do Serviço que incide sobre tipo de conta selecionado para pessoa jurídica(Campo Livre).
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Sigla de identificação de Outros Serviços que incidem sobre os tipos de contas informados.
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Fatos geradores de cobrança que incidem sobre serviço que compõe o Pacote de Serviços.
        /// </summary>
        [Required]
        public string ChargingTriggerInfo { get; set; }

        /// <summary>
        /// Lista distribuição preços tarifas de serviços.
        /// </summary>
        [Required]
        public List<Price> Prices { get; set; }

        /// <summary>
        /// Valor mínimo cobrado para a taxa de remuneração relativa ao serviço ofertado sobre a base de clientes no mês de referência.
        /// </summary>
        [Required]
        public MinimumPrice Minimum { get; set; }

        /// <summary>
        /// Valor máximo cobrado para a taxa de remuneração relativa ao serviço ofertado sobre a base de clientes no mês de referência.
        /// </summary>
        [Required]
        public MaximumPrice Maximum { get; set; }
    }
}
