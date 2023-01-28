using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class GeographicCoordinates
    {
        /// <summary>
        /// Informação da Latitude referente a geolocalização informada. Entre -90 e 90.p.ex. '-90.8365180'. (2 casas antes da vírgula, 11 posições)
        /// </summary>
        [Required]
        public string Latitude { get; set; }

        /// <summary>
        /// Informação da Longitude referente a geolocalização informada. Entre -180 e 180. p.ex '-180.836519.' (3 casas antes da vírgula, 11 posições)
        /// </summary>
        [Required]
        public string Longitude { get; set; }
    }
}
