using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class NationalityOtherDocument
    {
        /// <summary>
        /// Tipo de documento. Campo livre, de preenchimento obrigatório quando a nacionalidade for diferente de brasileira. Informar tipo e número do documento, além da, vigência e demais informações complementares para se identificar o documento de pessoa estrangeira
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// 	Número de identificação do documento. Campo livre, de preenchimento obrigatório quando a nacionalidade for diferente de brasileira. Informar o número do documento e demais informações complementares para se identificar o documento de pessoa estrangeira
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// Data de validade do documento informado, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Data de emissão do documento, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public string IssueDate { get; set; }

        /// <summary>
        /// 	Nome do país
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Campo livre de preenchimento obrigatório se selecionada a opção OUTROS tipos de documentos.
        /// </summary>
        public string TypeAdditionalInfo { get; set; }
    }
}
