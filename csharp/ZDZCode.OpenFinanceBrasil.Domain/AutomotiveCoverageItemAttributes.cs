using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Atributos da cobertura
    /// </summary>
    public class AutomotiveCoverageItemAttributes
    {
        /// <summary>
        /// No caso de contratação de várias coberturas numa mesma apólice, é comum o contrato estabelecer, para cada uma delas, um distinto limite máximo de responsabilidade por parte da seguradora. Cada um deles é denominado o Limite Máximo de Indenização (ou a Importância Segurada (IS), de cada cobertura contratada. Ressalte-se que estes limites são independentes, não se somando nem se comunicando. (Circular SUSEP 291/05); Lista com valor mínimo de LMI/IS aceito pela sociedade para cada cobertura. Em reais (R$) Importante: Campo de valor financeiro relacionado à cobertura que possui o campo. Quando não houver o campo, enviar o valor zerado.
        /// </summary>
        public CoverageItemAttributesMinLMI MinLMI { get; set; }

        /// <summary>
        /// Valor máximo de LMI/IS aceito pela sociedade para cada cobertura. Em reais (R$) Importante: Campo de valor numérico relacionado à cobertura que possui o campo. Quando não houver o campo, enviar o valor zerado.
        /// </summary>
        public CoverageItemAttributesMaxLMI MaxLMI { get; set; }

        /// <summary>
        ///
        /// </summary>
        public NewCar NewCar { get; set; }

        /// <summary>
        /// Será caracterizada a indenização integral quando os prejuízos resultantes de um mesmo sinistro, atingirem ou ultrapassarem a quantia apurada a partir da aplicação de percentual previamente determinado sobre o valor contratado. (Circular 269/2004).
        /// </summary>
        public string FullIndemnityPercentage { get; set; }

        /// <summary>
        /// Listagem de tipo de franquia para cada tipo de cobertura do produto.
        /// </summary>
        [Required]
        public List<EnumCoverageItemDeductibleType> DeductibleTypes { get; set; }

        /// <summary>
        /// (Circular 269/2004). A considerar os domínios abaixo:
        /// 1. true
        /// 2. false
        /// </summary>
        [Required]
        public bool FullIndemnityDeductible { get; set; }

        /// <summary>
        /// Mudança do campo com a sinalização para cada cobertura se a seguradora exige pagamento de franquia.
        /// 1. true
        /// 2. false
        /// </summary>
        public bool DeductiblePaymentByCoverage { get; set; }

        /// <summary>
        /// Percentual de Franquia
        /// </summary>
        public string DeductiblePercentage { get; set; }

        /// <summary>
        /// Participação Obrigatória é o valor ou percentual definido na apólice referente à responsabilidade do Segurado nos prejuízos indenizáveis decorrentes de sinistros cobertos. (Circular SUSEP 347/07). Listagem de percentual de Franquia/Percentual Participação Obrigatória do Segurado estabelecida pela sociedade para cada tipo de cobertura do produto.
        /// </summary>
        public string MandatoryParticipation { get; set; }

        /// <summary>
        ///
        /// </summary>
        public AutomotiveGeoGraphicScope GeographicScope { get; set; }

        /// <summary>
        /// Base de contratação
        /// </summary>
        public ContractBase ContractBase { get; set; }
    }
}
