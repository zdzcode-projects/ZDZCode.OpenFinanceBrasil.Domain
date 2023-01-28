using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BusinessPostalAddress
    {
        /// <summary>
        /// Indica se o endereço informado é o principal.
        /// </summary>
        [Required]
        public bool IsMain { get; set; }

        /// <summary>
        /// Corresponde ao endereço comercial do cliente.
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Alguns logradouros ainda necessitam ser especificados por meio de complemento.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Bairro é uma comunidade ou região localizada em uma cidade ou município de acordo com as suas subdivisões geográficas.
        /// </summary>
        [Required]
        public string DistrictName { get; set; }

        /// <summary>
        /// Localidade: O nome da localidade corresponde à designação da cidade ou município no qual o endereço está localizado.
        /// </summary>
        [Required]
        public string TownName { get; set; }

        /// <summary>
        /// Código IBGE de Município. A Tabela de Códigos de Municípios do IBGE apresenta a lista dos municípios brasileiros associados a um código composto de 7 dígitos, sendo os dois primeiros referentes ao código da Unidade da Federação.
        /// </summary>
        public string IbgeTownCode { get; set; }

        /// <summary>
        /// Enumeração referente a cada sigla da unidade da federação que identifica o estado ou o distrito federal, no qual o endereço está localizado. p.ex. 'AC'. São consideradas apenas as siglas para os estados brasileiros.
        /// </summary>
        [Required]
        public EnumCountrySubDivision CountrySubDivision { get; set; }

        /// <summary>
        /// Código de Endereçamento Postal: Composto por um conjunto numérico de oito dígitos, o objetivo principal do CEP é orientar e acelerar o encaminhamento, o tratamento e a entrega de objetos postados nos Correios, por meio da sua atribuição a localidades, logradouros, unidades dos Correios, serviços, órgãos públicos, empresas e edifícios. p.ex. '01311000'.
        /// </summary>
        [Required]
        public string PostCode { get; set; }

        /// <summary>
        /// Nome do país.
        /// </summary>
        [Required]
        public string Country { get; set; }

        /// <summary>
        /// Código do pais de acordo com o código “alpha3” do ISO-3166.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>   
        /// Conjunto de informações, que correspondem aos valores das coordenadas geográficas em graus decimais, no Sistema de referência WGS84.
        /// </summary>
        public GeographicCoordinates GeographicCoordinates { get; set; }
    }
}
