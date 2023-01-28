using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Conjunto de informações relativas a Identificação ou seja a ação e o efeito de identificar de forma única a pessoa natural através de seus dados cadastrais.
    /// </summary>
    public class PersonalIdentificationData
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Um identificador único e imutável usado para identificar o recurso cliente pessoa natural. Este identificador não tem significado para o cliente que deu o consentimento
        /// </summary>
        [Required]
        public string PersonalId { get; set; }

        /// <summary>
        /// Nome da Marca reportada pelo participante do Open Banking. O conceito a que se refere a 'marca' é em essência uma promessa da empresa em fornecer uma série específica de atributos, benefícios e serviços uniformes aos clientes
        /// </summary>
        [Required]
        public string BrandName { get; set; }

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
        /// Data de nascimento, conforme especificação RFC-3339
        /// </summary>
        [Required]
        public string BirthDate { get; set; }

        /// <summary>
        /// Estado marital do cliente.
        /// </summary>
        [Required]
        public EnumMaritalStatusCode MaritalStatusCode { get; set; }

        /// <summary>
        /// 	Campo livre para complementar a informação relativa ao estado marital, quando selecionada a opção 'OUTROS'
        /// </summary>
        public string MaritalStatusAdditionalInfo { get; set; }

        /// <summary>
        /// "Conjunto de características anatomofisiológicas que distinguem o homem e a mulher: Sexo masculino; sexo feminino". No caso de não ser feminino nem masculino é classificado como 'OUTRO'
        /// </summary>
        [Required]
        public EnumSex Sex { get; set; }

        /// <summary>
        /// Número completo do CNPJ da instituição responsável pelo Cadastro - o CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara
        /// </summary>
        [Required]
        public List<string> CompanyCnpj { get; set; }

        /// <summary>
        /// Objeto agrupador de informações relativas a Documentos da pessoa natural
        /// </summary>
        [Required]
        public PersonalDocument Documents { get; set; }

        /// <summary>
        /// Relação dos demais documentos
        /// </summary>
        [Required]
        public List<PersonalOtherDocument> OtherDocuments { get; set; }

        /// <summary>
        /// Informa se o Cliente tem nacionalidade brasileira.
        /// </summary>
        [Required]
        public bool HasBrazilianNationality { get; set; }

        /// <summary>
        /// [Objeto que agrupa informações relativas à nacionalidade da Pessoa Natural]
        /// </summary>
        [Required]
        public List<Nationality> Nationality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<Filiation> Filiation { get; set; }

        /// <summary>
        /// Conjunto de informações referentes às formas para contatar o cliente.
        /// </summary>
        [Required]
        public PersonalContacts Contacts { get; set; }
    }
}
