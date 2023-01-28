using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class GetSurvivalPensionContractData
    {
        /// <summary>
        /// Conjunto de informações relativas ao participante do produto de open banking
        /// </summary>
        [Required]
        public Participant Participant { get; set; }

        /// <summary>
        /// Conjunto de informações relativas à seguradora do produto de open insurance
        /// </summary>
        public Society Society { get; set; }

        /// <summary>
        /// Nome comercial do produto, pelo qual é identificado nos canais de distribuição e atendimento da sociedade.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Código único a ser definido pela sociedade.
        /// </summary>
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// Segmento do qual se trata o produto contratado
        /// 1. Seguro de Pessoas
        /// 2. Previdência
        /// </summary>
        [Required]
        public string Segment { get; set; }

        /// <summary>
        /// 1. Contribuição Variável;
        /// 2. Benefício Definido.
        /// </summary>
        public string Modality { get; set; }

        /// <summary>
        /// Campo aberto (possibilidade de incluir URL)
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        public List<TermsAndConditions> TermsAndConditions { get; set; }

        /// <summary>
        /// 1. PGBL, 2. PRGP, 3. PAGP, 4. PRSA, 5. PRI, 6. PDR, 7. VGBL, 8. VRGP, 9. VAGP, 10. VRSA, 11. VRI, 12. VDR, 13. Demais produtos de Previdência.
        /// </summary>
        [Required]
        public SurvivalPensionType Type { get; set; }

        /// <summary>
        /// Período de Diferimento
        /// </summary>
        public SurvivalPensionDefferalPeriod DefferalPeriod { get; set; }

        /// <summary>
        /// Período de concessão do benefício
        /// </summary>
        public SurvivalPensionGrantPeriodBenefit GrantPeriodBenefit { get; set; }

        /// <summary>
        /// Custos
        /// </summary>
        public SurvivalPensionCosts Costs { get; set; }

        /// <summary>
        ///
        /// </summary>
        public SurvivalPensionMinimumRequirements MinimumRequirement { get; set; }

        /// <summary>
        /// A considerar os domínios abaixo:
        /// 1. Pessoa Natural
        /// 2. Pessoa Jurídica
        /// 3. Ambas(Pessoa Natural e Jurídica)
        /// </summary>
        [Required]
        public EnumTargetAudience TargetAudience { get; set; }
    }
}
