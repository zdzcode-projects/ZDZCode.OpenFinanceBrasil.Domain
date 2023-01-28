
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Participant
    {
        /// <summary>
        /// Nome da marca reportada pelo participante do Open Banking. O conceito a que se refere a 'marca' é em essência uma promessa da empresa em fornecer uma série específica de atributos, benefícios e serviços uniformes aos clientes.
        /// </summary>
        [Required]
        public string Brand { get; set; }

        /// <summary>
        /// Nome do participante do Open Banking.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// O CNPJ corresponde ao número de inscrição no Cadastro de Pessoa Jurídica. Deve-se ter apenas os números do CNPJ, sem máscara.
        /// </summary>
        [Required]
        public CnpjNumber CnpjNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string UrlComplementaryList { get; set; }
    }
}
