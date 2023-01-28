using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgentsPostalAddress
    {
        /// <summary>
        /// informação referente ao endereço do Correspondente Bancário informado: Tipo de logradouro + Nome do logradouro + Número do Logradouro (se não existir usar ' s/n') + complemento (se houver).
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Bairro.
        /// </summary>
        [Required]
        public string DistrictName { get; set; }

        /// <summary>
        /// Cidade.
        /// </summary>
        [Required]
        public string TownName { get; set; }

        /// <summary>
        /// Estado.
        /// </summary>
        [Required]
        public string CountrySubDivision { get; set; }

        /// <summary>
        /// CEP.
        /// </summary>
        [Required]
        public string PostCode { get; set; }

        /// <summary>
        /// Alguns logradouros ainda necessitam ser especificados por meio de complemento, conforme o exemplo a seguir: 'Loja B', 'Fundos', 'Casa 2', 'Lote C'
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Código IBGE de Município. A Tabela de Códigos de Municípios do IBGE apresenta a lista dos municípios brasileiros associados a um código composto de 7 dígitos, sendo os dois primeiros referentes ao código da Unidade da Federação. p.ex.'3550308'
        /// </summary>
        public string IbgeCode { get; set; }

        /// <summary>
        /// Nome do país. p.ex. Brasil
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Código do pais de acordo com o código “alpha3” do ISO-3166.p.ex.'BRA'
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Informação referente a geolocalização informada.
        /// </summary>
        [Required]
        public BankingAgentsGeographicCoordinates GeographicCoordinates { get; set; }
    }
}
