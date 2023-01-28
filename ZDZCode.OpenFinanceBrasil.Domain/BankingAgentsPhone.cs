using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgentsPhone
    {
        /// <summary>
        /// Identificação do Tipo de telefone da dependência. p.ex.FIXO, MOVEL.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Número de DDI (Discagem Direta Internacional) para telefone de acesso ao Canal - se houver. p.ex. '55'.
        /// </summary>
        public string CountryCallingCode { get; set; }

        /// <summary>
        /// Número de DDD (Discagem Direta à Distância) do telefone da dependência - se houver. p.ex. '19'.
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// Número de telefone da dependência - se houver.
        /// </summary>
        public string Number { get; set; }
    }
}
