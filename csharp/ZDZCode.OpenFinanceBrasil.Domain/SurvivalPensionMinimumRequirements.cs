using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SurvivalPensionMinimumRequirements //possui valores enum no site, confirmar com o Zids,
    {
        /// <summary>
        /// O tipo de serviço contratado. A considerar os domínios abaixo:
        /// 1. Coletivo Averbado;
        /// 2. Individual.
        /// 3. Ambas
        /// </summary>
        [Required]
        public string ContractType { get; set; }

        /// <summary>
        /// Indicação se o plano é destinado para participante qualificado. A considerar os domínios abaixo:
        /// 1. true
        /// 2. false
        /// </summary>
        [Required]
        public bool ParticipantQualified { get; set; }

        /// <summary>
        /// Campo aberto (possibilidade de incluir URL)
        /// </summary>
        [Required]
        public string ContractingMinRequirement { get; set; }

        //COLETIVO = 1,
        //INDIVIDUAL = 2,
        //AMBAS = 3

    }
}
