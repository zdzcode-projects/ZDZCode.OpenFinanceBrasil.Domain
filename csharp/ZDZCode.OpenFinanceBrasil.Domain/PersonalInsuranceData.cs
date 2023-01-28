using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalInsuranceData
    {
        /// <summary>
        /// Conjunto de informações relativas ao participante do produto de open banking
        /// </summary>
        [Required]
        public Participant Participant { get; set; }

        /// <summary>
        /// Conjunto de informações relativas à seguradora do produto de open insurance
        /// </summary>
        [Required]
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
        /// Indicar a categoria do Produto:
        /// 1.Tradicional
        /// 2.Microsseguro
        /// </summary>
        public EnumInsurancePensionCategory Category { get; set; }

        /// <summary>
        /// 1.Funeral
        /// 2.Prestamista(exceto Habitacional e Rural)
        /// 3.Viagem
        /// 4.Educacional
        /// 5.Dotal(Misto e Puro)
        /// 6.Acidentes Pessoais
        /// 7.Vida
        /// 8.Perda do Certificado de Habilitação de Voo – PCHV
        /// 9.Doenças Graves ou Doença Terminal
        /// 10.Desemprego/ Perda de Renda
        /// 11.Eventos Aleatórios
        /// 12.Pecúlio
        /// 13.Pensão prazo certo
        /// 14.Pensão menores 21 anos
        /// 15.Pensão menores 24 anos
        /// 16.Pensão cônjuge vitalícia
        /// 17.Pensão cônjuge temporária
        /// /summary>
        public EnumProductModality Modality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<PersonalCoverageItem> Coverages { get; set; }

        /// <summary>
        /// [Lista padronizada de tipo de assistências ofertadas vinculadas ao produto. Por exemplo, Funeral, Bicicleta, Assistência PET – Tabela padrão a ser consolidada com retorno das empresas com a relação de assistências, permitindo um campo ‘Outros’ para assistências não contempladas na tabela padronizada.]
        /// </summary>
        [Required]
        public List<EnumAssistanceType> AssistanceTypes { get; set; }

        /// <summary>
        /// Lista a ser preenchido pelas participantes quando houver ‘Outros’ no campo ‘Tipo de Assistência’
        /// </summary>
        public List<string> AssistanceTypesAdditionalInfos { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<EnumAdditional> Additionals { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<TermsAndConditions> TermsAndConditions { get; set; }

        /// <summary>
        /// A considerar os seguintes domínios:
        /// 1. true
        /// 2. false
        /// </summary>
        public bool GlobalCapital { get; set; }

        /// <summary>
        /// [Define o prazo do plano contratado
        /// 1.Vitalícia
        /// 2.Temporária - prazo fixo
        /// 3.Temporária – intermitente]
        /// </summary>
        [Required]
        public List<EnumTerm> Terms { get; set; }

        /// <summary>
        ///
        /// </summary>
        public InsurancePensionEnumPmbacRemuneration PmbacRemuneration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InsurancePensionBenefitRecalculation BenefitRecalculation { get; set; }

        /// <summary>
        ///
        /// </summary>
        public AgeAdjustment AgeAdjustment { get; set; }

        /// <summary>
        /// [Listagem de regime financeiro para cada combinação de modalidade/cobertura do produto indicando:
        /// 1. Repartição simples
        /// 2. Repartição Capitais Cobertura
        /// 3. Capitalização ]
        /// </summary>
        public List<InsurancePensionEnumFinancialRegime> FinancialRegimes { get; set; }

        /// <summary>
        ///
        /// </summary>
        public InsurancePensionReclaim Reclaim { get; set; }

        /// <summary>
        /// [1. Saldamento
        /// 2. Benefício Prolongado
        /// 3. Não se aplica ]
        /// </summary>
        public List<EnumPersonalInsuranceOtherGuaranteedValues> OtherGuaranteedValues { get; set; }

        /// <summary>
        /// 1. true
        /// 2. false
        /// </summary> 
        public bool AllowPortability { get; set; }

        /// <summary>
        ///
        /// </summary>
        public GracePeriod PortabilityGraceTime { get; set; }

        /// <summary>
        /// [Modalidade de pagamento da indenização, a considerar os domínios abaixo:
        /// 1. Único
        /// 2. Sob a forma de renda]
        /// </summary>
        [Required]
        public List<EnumPersonalInsuranceIndemnityPaymentMethod> IndemnityPaymentMethods { get; set; }

        /// <summary>
        /// [Tipo de renda ou pensão, caso modalidade de pagamento de indenização seja sob a forma de renda:
        /// 1. Certa
        /// 2. Temporária
        /// 3. Temporária reversível
        /// 4. Temporário com mínimo garantido
        /// 5. Temporária reversível com mínimo garantido
        /// 6. Vitalícia
        /// 7. Vitalícia reversível
        /// 8. Vitalícia com o mínimo garantido
        /// 9. Vitalícia reversível como mínimo garantido ]
        /// </summary>
        public List<EnumPersonalInsuranceIndemnityPaymentIncome> IndemnityPaymentIncomes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public PersonalInsurancePremiumPayment PremiumPayment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InsuranceMinimumRequirement MinimumRequirement { get; set; }

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
