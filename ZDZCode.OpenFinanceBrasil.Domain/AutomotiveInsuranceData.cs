using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class AutomotiveInsuranceData
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
        /// Coberturas
        /// </summary>
        [Required]
        public List<AutomotiveCoverageItem> Coverages { get; set; }

        /// <summary>
        /// Tipo de peça utilizada para reparação – Nova ou Usada.
        /// </summary>
        public List<AutomotivePartsItem> CarParts { get; set; }

        /// <summary>
        ///
        /// </summary>
        public AutomotiveModel CarModel { get; set; }

        /// <summary>
        /// O conjunto de dados de Produtos que vai retornar está condicionado ao input do valor de CEP (Filtro). Nesse contexto será necessário que o CEP de consulta seja inserido. Código de Endereçamento Postal: Composto por um conjunto numérico de oito dígitos, o objetivo principal do CEP é orientar e acelerar o encaminhamento, o tratamento e a entrega de objetos postados nos Correios, por meio da sua atribuição a localidades, logradouros, unidades dos Correios, serviços, órgãos públicos, empresas e edifícios. p.ex. '01311000'
        /// </summary>
        public int VehicleOvernightPostalCode { get; set; }

        /// <summary>
        /// [A considerar os seguintes domínios abaixo:
        /// 1. Sorteio Gratuito
        /// 2. Clube de Benefícios
        /// 3. Cashback
        /// 4. Descontos
        /// 5. Outros]
        /// </summary>
        public List<EnumInsuranceAdditionalType> Additionals { get; set; }

        /// <summary>
        /// Campo aberto para descrição de cada participante ao selecionar o domínio ‘Outros’ no campo acima ‘Adicionais’ diferenciais do produto em questão.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Serviços de Assistência
        /// </summary>
        public List<AssistanceServicesItem> AssistanceServices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<TermsAndConditions> TermsAndConditions { get; set; }

        /// <summary>
        /// [1. anual
        /// 2. anual intermitente
        /// 3. plurianual
        /// 4. plurianual intermitente
        /// 5. semestral
        /// 6. semestral intermitente
        /// 7. mensal
        /// 8. mensal intermitente
        /// 9. diário
        /// 10. diário intermitente
        /// 11. Outros]
        /// </summary>
        [Required]
        public List<EnumInsuranceTermType> Terms { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao campo terms, quando for selecionada a opção 'Outros'
        /// </summary>
        public string TermsAdditionalInfo { get; set; }

        /// <summary>
        /// Rede de atendimento do seguro contratado. A considerar os domínios abaixo:
        /// 1. Rede Referenciada
        /// 2. Livre Escolha
        /// 3. Rede Referenciada e Livre Escolha
        /// </summary>
        public EnumCustomerServiceType CustomerService { get; set; }

        /// <summary>
        ///
        /// </summary>
        public PremiumPayment PremiumPayment { get; set; }

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
