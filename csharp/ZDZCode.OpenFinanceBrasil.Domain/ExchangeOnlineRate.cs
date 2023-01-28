using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações referentes às informações de câmbio
    /// </summary>
    public class ExchangeOnlineRate
    {
        /// <summary>
        /// Conjunto de informações relativas ao participante do produto de open banking
        /// </summary>
        [Required]
        public Participant Participant { get; set; }

        /// <summary>
        /// [Taxa disponibilizada (taxa online) pelas instituições no formato D+0/D+2 (valor U$500 operações câmbio pronto) separado por moeda dólar e euro compra e venda PF/PJ.]
        /// </summary>
        [Required]
        public List<OnlineRate> Values { get; set; }

        /// <summary>
        /// Timestamp do momento da consulta
        /// </summary>
        [Required]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Disclaimer informando que a taxa apresentada é somente informativa, para a contratação de uma operação, deverá ser consultado o canal correspondente de cada instituição.
        /// </summary>
        [Required]
        public string Disclaimer { get; set; }
    }
}
