using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AccountOtherService 
    {
        /// <summary>
        /// Nome atribuído a Outros Serviços disponíveis para os tipos de contas.
        /// </summary>
        [Required]
        public string Name { get; set; } 

        /// <summary>
        /// Sigla de identificação de Outros Serviços que incidem sobre os tipos de contas.
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Outros Fatos geradores de cobrança referentes aos Outros Serviços que incidem sobre as contas comercializadas.
        /// </summary>
        [Required]
        public string ChargingTriggerInfo { get; set; }

        /// <summary>
        /// alor da tarifa cobrada referente aos Outros Serviços.
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