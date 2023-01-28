using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalOtherDocument
    {
        /// <summary>
        /// Relação dos Códigos dos demais documentos pessoa natural.
        /// </summary>
        [Required]
        public EnumPersonalOtherDocumentType Type { get; set; }

        /// <summary>
        /// Campo livre de preenchimento obrigatório se selecionada a opção OUTROS tipos de documentos
        /// </summary>
        [Required]
        public string TypeAdditionalInfo { get; set; }

        /// <summary>
        /// Identificação/Número do documento informado
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Dígito verificador do documento informado. De preenchimento obrigatório se o documento informado tiver dígito verificador
        /// </summary>
        [Required]
        public string CheckDigit { get; set; }

        /// <summary>
        /// Para documentos em que se aplique o uso do local de emissão o mesmo deve ser enviado mandatoriamente, com a informação de órgão e UF. Exemplo: RG, local de emissão: SSP/RS. [Restrição] Obrigatório quando o Local de Emissão do Documento for relevante.
                /// </summary>
        [Required]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Data de validade do documento informado, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public string ExpirationDate { get; set; }
    }
}
