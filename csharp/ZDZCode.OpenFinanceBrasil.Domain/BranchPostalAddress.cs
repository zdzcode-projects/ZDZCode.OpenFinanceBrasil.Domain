using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BranchPostalAddress
    {
        /// <summary>
        /// Deverá trazer toda a informação referente ao endereço da dependência informada: Tipo de logradouro + Nome do logradouro + Número do Logradouro (se não existir usar ' s/n') + complemento (se houver), como, p.ex.: 'R Diamatina, 59, bloco 35, fundos', 'Praça da Boa Vontade s/n'.
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Alguns logradouros ainda necessitam ser especificados por meio de complemento, conforme o exemplo a seguir: 'Loja B', 'Fundos', 'Casa 2', 'Lote C'.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Bairro é uma comunidade ou região localizada em uma cidade ou município de acordo com as suas subdivisões geográficas. p.ex: 'Paraíso'.
        /// </summary>
        [Required]
        public string DistrictName { get; set; }

        /// <summary>
        /// O nome da localidade corresponde à designação da cidade ou município no qual o endereço está localizado. p.ex. 'São Paulo'.
        /// </summary>
        [Required]
        public string TownName { get; set; }

        /// <summary>
        /// Código IBGE de Município. A Tabela de Códigos de Municípios do IBGE apresenta a lista dos municípios brasileiros associados a um código composto de 7 dígitos, sendo os dois primeiros referentes ao código da Unidade da Federação. p.ex.'3550308'.
        /// </summary>
        public string IbgeCode { get; set; }

        /// <summary>
        /// Enumeração referente a cada sigla da unidade da federação que identifica o estado ou o distrito federal, no qual o endereço está localizado. p.ex. 'AC'. São consideradas apenas as siglas para os estados brasileiros.
        /// </summary>
        [Required]
        public string CountrySubDivision { get; set; }

        /// <summary>
        /// Código de Endereçamento Postal: Composto por um conjunto numérico de oito dígitos, o objetivo principal do CEP é orientar e acelerar o encaminhamento, o tratamento e a entrega de objetos postados nos Correios, por meio da sua atribuição a localidades, logradouros, unidades dos Correios, serviços, órgãos públicos, empresas e edifícios. p.ex. '01311-000'.
        /// </summary>
        [Required]
        public string PostCode { get; set; }

        /// <summary>
        /// Nome do país. p.ex. Brasil.
        /// </summary>
        [Required]
        public string Country { get; set; }

        /// <summary>
        /// Código do pais de acordo com o código “alpha3” do ISO-3166.p.ex.'BRA'.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Informação referente a geolocalização informada.
        /// </summary>
        public BranchesGeographicCoordinates GeographicCoordinates { get; set; }
    }
}
