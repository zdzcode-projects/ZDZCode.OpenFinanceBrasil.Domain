using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class PersonalDocument
    {
        /// <summary>
        /// Número completo do CPF. Atributo que corresponde às informações mínimas exigidas pela Regulamentação em vigor. O CPF é o Cadastro de Pessoa natural. Ele é um documento feito pela Receita Federal e serve para identificar os contribuintes. O CPF é uma numeração com 11 dígitos, que só mudam por decisão judicial. O documento é emitido pela receita federal
        /// </summary>
        [Required]
        public string CpfNumber { get; set; }

        /// <summary>
        /// 	Número do Passaporte. Documento concedido aos viajantes por uma autoridade administrativa nacional a fim de certificar sua identidade perante autoridades estrangeiras.De preenchimento obrigatório.Aplicável somente à Pessoa natural residente no exterior desobrigada de inscrição no CPF.
        /// </summary>
        [Required]
        public string PassportNumber { get; set; }

        /// <summary>
        /// Pais de emissão do passaporte. Código do pais de acordo com o código 'alpha3' do ISO-3166.
        /// </summary>
        [Required]
        public string PassportCountry { get; set; }

        /// <summary>
        /// 	Data vigência do Passaporte, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public string PassportExpirationDate { get; set; }

        /// <summary>
        /// Data de emissão do passaporte, conforme especificação RFC-3339.
        /// </summary>
        [Required]
        public string PassportIssueDate { get; set; }
    }
}
