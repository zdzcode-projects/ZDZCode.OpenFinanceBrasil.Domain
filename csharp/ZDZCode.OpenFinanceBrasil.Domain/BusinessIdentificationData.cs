using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BusinessIdentificationData
    {
        /// <summary>
        /// Data e hora da atualização do bloco, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        /// Um identificador único e imutável usado para identificar o recurso cliente pessoa jurídica. Este identificador não tem significado para o cliente que deu o consentimento.
        /// </summary>
        [Required]
        public string BusinessId { get; set; }

        /// <summary>
        /// Nome da Marca reportada pelo participante do Open Banking. O conceito a que se refere a 'marca' é em essência uma promessa da empresa em fornecer uma série específica de atributos, benefícios e serviços uniformes aos clientes.
        /// </summary>
        [Required]
        public string BrandName { get; set; }

        /// <summary>
        /// Razão social da empresa consultada é o termo registrado sob o qual uma pessoa jurídica (PJ) se individualiza e exerce suas atividades. Também pode ser chamada por denominação social ou firma empresarial.
        /// </summary>
        [Required]
        public string CompanyName { get; set; }

        /// <summary>
        /// Nome fantasia da pessoa jurídica, se houver. (É o nome popular da empresa, utilizado para divulgação da empresa e melhor fixação com o público). De preenchimento obrigatório se houver.
        /// </summary>
        [Required]
        public string TradeName { get; set; }

        /// <summary>
        /// Data de constituição da empresa, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public DateTime IncorporationDate { get; set; }

        /// <summary>
        /// Número completo do CNPJ da Empresa consultada - o CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara.
        /// </summary>
        [Required]
        public string CnpjNumber { get; set; }

        /// <summary>
        /// Número completo do CNPJ da instituição responsável pelo Cadastro - o CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara.
        /// </summary>
        [Required]
        public List<string> CompanyCnpjNumber { get; set; }

        /// <summary>
        /// Relação dos demais documentos.
        /// </summary>
        [Required]
        public List<BusinessOtherDocument> OtherDocuments { get; set; }

        /// <summary>
        /// Lista relativa às informações das partes envolvidas, como: sócio e /ou administrador.
        /// </summary>
        [Required]
        public List<PartiesParticipation> Parties { get; set; }

        /// <summary>
        /// Conjunto de informações referentes às formas para contatar o cliente.
        /// </summary>
        [Required]
        public BusinessContacts Contacts { get; set; }
    }
}
