using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCreditCardRewardProgram
    {
        /// <summary>
        /// Indicador da existência de programa de fidelidade/recompensa associado à conta
        /// </summary>
        [Required]
        public bool hasRewardProgram { get; set; }

        /// <summary>
        /// Informações de termos e condições do programa de fidelidade/recompensa. Pode ser informada a URL referente ao endereço onde constam as condições informadas
        /// </summary>
        [Required]
        public string rewardProgramInfo { get; set; }
    }
}
