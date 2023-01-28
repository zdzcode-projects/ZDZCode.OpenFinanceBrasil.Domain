using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ServiceBundle
    {
        /// <summary>
        ///Nome do Pacote de Serviços dado pela instituição.
        /// </summary>
        [Required]
        public string? name { get; set; }

        /// <summary>
        /// Lista dos serviços que compõem o pacote de serviços.
        /// </summary>
        [Required]
        public ServiceBundleServiceDetail services { get; set; } = new ServiceBundleServiceDetail();

        /// <summary>
        /// Lista distribuição preços tarifas de serviços.
        /// </summary>
        [Required]
        public MonthlyPrice prices { get; set; }

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
