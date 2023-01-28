using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Filiation
    {
        /// <summary>
        /// Tipo de filiação.
        /// </summary>
        [Required]
        public EnumFiliationType Type { get; set; }

        /// <summary>
        /// Nome civil completo da pessoa relativa à filiação. (Direito fundamental da pessoa, o nome civil é aquele atribuído à pessoa natural desde o registro de seu nascimento, com o qual será identificada por toda a sua vida, bem como após a sua morte)
        /// </summary>
        [Required]
        public string CivilName { get; set; }

        /// <summary>
        /// Nome social da pessoa natural, se houver. (aquele pelo qual travestis e transexuais se reconhecem, bem como são identificados por sua comunidade e em seu meio social, conforme Decreto Local)
        /// </summary>
        public string SocialName { get; set; }
    }
}
