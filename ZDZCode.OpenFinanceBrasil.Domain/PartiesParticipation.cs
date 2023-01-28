using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PartiesParticipation
    {
        /// <summary>
        /// Indica se a pessoa da parte envolvida é uma pessoa natural ou juridica
        /// </summary>
        [Required]
        public EnumPersonType PersonType { get; set; }

        /// <summary>
        /// Indica o perfil de atuação na empresa. Vide Enum. O administrador é o responsável por desempenhar todas as funções administrativas da empresa.É ele quem conduz o dia a dia do negócio, assinando documentos, respondendo legalmente pela sociedade, realizando empréstimos e outras ações gerenciais. Apesar de estar na linha de frente da empresa, ele é denominado sócio por também possuir sua parcela de participação no Capital Social. Sócio não tem qualquer envolvimento nas atividades administrativas da sociedade.
        /// </summary>
        [Required]
        public EnumPartiesParticipationType Type { get; set; }

        /// <summary>
        /// Nome civil completo da pessoa natural (Direito fundamental da pessoa, o nome civil é aquele atribuído à pessoa natural desde o registro de seu nascimento, com o qual será identificada por toda a sua vida, bem como após a sua morte)
        /// </summary>
        [Required]
        public string CivilName { get; set; }

        /// <summary>
        /// Nome social da pessoa natural, se houver. (aquele pelo qual travestis e transexuais se reconhecem, bem como são identificados por sua comunidade e em seu meio social, conforme Decreto Local)
        /// </summary>
        [Required]
        public string SocialName { get; set; }

        /// <summary>
        /// Razão social da empresa consultada é o termo registrado sob o qual uma pessoa jurídica (PJ) se individualiza e exerce suas atividades. Também pode ser chamada por denominação social ou firma empresarial
        /// </summary>
        [Required]
        public string CompanyName { get; set; }

        /// <summary>
        ///	Nome fantasia da pessoa jurídica, se houver. (É o nome popular da empresa, utilizado para divulgação da empresa e melhor fixação com o público). De preenchimento obrigatório se houver
        /// </summary>
        [Required]
        public string TradeName { get; set; }

        /// <summary>
        /// Data de início da participação, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Percentual de participação societária (informar com 2 casas decimais). Sócio só deve ser informado se sua participação societária for igual ou superior a 25%. p.ex: 0.25 (Este valor representa 25%. O valor '1 'representa 100%)
        /// </summary>
        [Required]
        public string Shareholding { get; set; }

        /// <summary>
        /// Tipo do documento informado.
        /// </summary>
        [Required]
        public EnumPartiesParticipationDocumentType DocumentType { get; set; }

        /// <summary>
        /// Número do documento informado. Campo Texto Livre para preencher número e dígito do documento se houver
        /// </summary>
        [Required]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Campo livre, de preenchimento obrigatório quando o documento informado tiver informações complementares relevantes para a sua identificação
        /// </summary>
        public string DocumentAdditionalInfo { get; set; }

        /// <summary>
        /// País de emissão do documento. Código do pais de acordo com o código alpha3 do ISO-3166.
        /// </summary>
        [Required]
        public string DocumentCountry { get; set; }

        /// <summary>
        /// Data de validade do documento informado, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public string DocumentExpirationDate { get; set; }

        /// <summary>
        /// Data de emissão do documento, conforme especificação RFC-3339.
        /// </summary>
        public string DocumentIssueDate { get; set; }
    }
}
