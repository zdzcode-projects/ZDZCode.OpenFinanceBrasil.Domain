using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AutomotivePartsItem //Possui valores enum no site. Confirmar com o Zids.
    {
        /// <summary>
        /// Novas ou usada. A considerar os domínios abaixo:
        /// 1. Novas
        /// 2. Usadas
        /// 3. Ambas
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Originais e Compatíveis. A considerar os domínios abaixo:
        /// 1. Originais
        /// 2. Compatíveis
        /// 3. Ambas
        /// </summary>
        public EnumAutomotivePartType Type { get; set; }
    }
}
