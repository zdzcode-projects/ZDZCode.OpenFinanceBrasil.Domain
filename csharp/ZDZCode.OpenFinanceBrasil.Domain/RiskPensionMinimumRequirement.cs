using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class RiskPensionMinimumRequirement //Tem valores enum, confirmar com o Zids.
    {
        /// <summary>
        ///O tipo de serviço contratado. A considerar os domínios abaixo:
        /// 1.Coletivo Averbado
        /// 2.Coletivo Instituído
        /// 3.Individual
        /// </summary>
        [Required]
        public string ContractType { get; set; }

        /// <summary>
        /// Campo aberto contendo todos os requisitos mínimos para contratação (possibilidade de incluir URL).
        /// </summary>
        public string ContractingMinRequirement { get; set; }


        //COLETIVO_AVERBADO = 1,
        //COLETIVO_INSTITUIDO = 2,
        //INDIVIDUAL = 3,
    }
}
