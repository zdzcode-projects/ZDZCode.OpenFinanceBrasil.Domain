using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class HomePropertyCharacteristics
    {
        /// <summary>
        /// Proposta conforme os domínios abaixo:
        /// 1. Casa
        /// 2. Apartamento
        /// </summary>
        [Required]
        public EnumHomePropertyType Type { get; set; }

        /// <summary>
        /// [A considerar os seguintes domínios abaixo:
        /// 1. Alvenaria
        /// 2. Madeira
        /// 3. Mista(Alvenaria e Madeira)]
        /// </summary>
        [Required]
        public List<EnumHomePropertyBuildType> BuildTypes { get; set; }

        /// <summary>
        /// [A considerar os seguintes domínios abaixo:
        /// 1. Habitual
        /// 2. Veraneio
        /// 3. Desocupado
        /// 4. Casa/Escritório
        /// 5. Aluguel por temporada]
        /// </summary>
        [Required]
        public List<EnumHomePropertyUsageType> UsageTypes { get; set; }

        /// <summary>
        /// [A considerar os seguintes domínios abaixo:
        /// 1. Prédio
        /// 2. Conteúdo
        /// 3. Ambos]
        /// </summary>
        [Required]
        public List<EnumHomeImportanceInsuredType> ImportanceInsureds { get; set; }
    }
}
