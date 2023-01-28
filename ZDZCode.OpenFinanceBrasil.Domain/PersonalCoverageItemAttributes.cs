using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalCoverageItemAttributes
    {
        /// <summary>
        /// Listagem da forma de pagamento da indenização para cada combinação de modalidade/cobertura do produto.
        /// </summary>
        public List<EnumIdemnityPaymentMethod> IndemnityPaymentMethods { get; set; }

        /// <summary>
        /// Listagem de tipos de frequência de pagamento de indenização para cada combinação de modalidade/cobertura do produto.
        /// </summary>
        public List<EnumPersonalIndemnityPaymentFrequencyType> IndemnityPaymentFrequencies { get; set; }

        /// <summary>
        /// Listagem do valor mínimo de cobertura (Capital Segurado), diária ou parcela aceito pela sociedade para cada combinação de modalidade/cobertura do produto. Conforme moeda.
        /// </summary>
        [Required]
        public InsurancePensionMinValue MinValue { get; set; }

        /// <summary>
        /// Listagem do valor máximo de cobertura (Capital Segurado), diária ou parcela aceito pela sociedade para cada combinação de modalidade/cobertura do produto. Conforme moeda.
        /// </summary>
        [Required]
        public InsurancePensionMaxValue MaxValue { get; set; }

        /// <summary>
        /// [Listagem do pagamento para cada benefício:
        /// 1. Quantidade determinada de parcelas;
        /// 2. Até o fim de ciclo determinado.
        /// Se for pagamento único, esse campo não se aplica (retorna vazio). ]
        /// </summary>
        public List<InsurancePensionEnumIndemnifiablePeriodType> IndemnifiablePeriods { get; set; }

        /// <summary>   
        /// Caso o período indenizável seja relacionado a parcelas, listagem de número máximo de parcelas indenizáveis para cada combinação de modalidade/ cobertura do produto.
        /// </summary>
        public int MaximumQtyIndemnifiableInstallments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public GracePeriod GracePeriod { get; set; }

        /// <summary>
        ///
        /// </summary>
        public GracePeriod DifferentiatedGracePeriod { get; set; }

        /// <summary>
        /// Listagem de franquia em dias para cada combinação de modalidade/cobertura do produto.
        /// </summary>
        public int DeductibleDays { get; set; }

        /// <summary>
        /// Detalhamento da franquia em dias diferentes para cada cobertura que exista alguma especificidade. Caso a seguradora não tenha essa diferenciação, não retornará nada no campo.
        /// </summary>
        public int DifferentiatedDeductibleDays { get; set; }

        /// <summary>
        /// Listagem de franquia em reais para cada combinação de modalidade/cobertura do produto.
        /// </summary>
        public InsurancePensionCoverageDeductible Deductible { get; set; }

        /// <summary>
        /// Detalhamento da franquia em reais diferentes para cada cobertura que exista alguma especificidade. Caso a seguradora não tenha essa diferenciação, não retornará nada no campo.
        /// </summary>
        public InsurancePensionCoverageDifferentiatedDeductible DifferentiatedDeductible { get; set; }

        /// <summary>
        /// [Listagem para indicar quais serão o(s) risco(s) excluído(s) aplicável(is) à(s) cobertura(s).]
        /// </summary>
        public List<EnumExcludedRisks> ExcludedRisks { get; set; }

        /// <summary>
        /// Campo aberto (possibilidade de incluir URL)
        /// </summary>
        public string ExcludedRisksURL { get; set; }

        /// <summary>
        /// Indicar se a cobertura pode ser contratada isoladamente ou não:
        /// 1. true
        /// 2. false
        /// </summary>
        public bool AllowApartPurchase { get; set; }
    }
}
