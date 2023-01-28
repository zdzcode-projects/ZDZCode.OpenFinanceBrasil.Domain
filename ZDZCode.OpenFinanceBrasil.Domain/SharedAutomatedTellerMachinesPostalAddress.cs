using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SharedAutomatedTellerMachinesPostalAddress
    {
        /// <summary>
        /// Informação referente ao endereço da máquina compartilhada de autoatendimento
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 	Complemento
        /// </summary>
        public string additionalInfo { get; set; }

        /// <summary>
        /// 	Bairro
        /// </summary>
        public string districtName { get; set; }

        /// <summary>
        /// 	Cidade
        /// </summary>
        public string townName { get; set; }

        /// <summary>
        /// Código IBGE do município
        /// </summary>
        public string ibgeCode { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public string countrySubDivision { get; set; }

        /// <summary>
        /// CEP
        /// </summary>
        public string postCode { get; set; }

        /// <summary>
        /// País
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Código do país

        /// </summary>
        public string countryCode { get; set; }

        /// <summary>
        /// Informação referente a geolocalização da máquina compartilhada de autoatendimento
        /// </summary>
        public GeographicCoordinates geographicCoordinates { get; set; }




    }
}
