using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Objeto que reúne as informações relativas ao relacionamento do cliente junto à Instituição. Considera-se relacionamento as informações que permitam conhecer desde quando a pessoa consultada é cliente da instituição, bem como um indicador dos produtos e serviços que ela consome atualmente e seus representantes.
    /// </summary>
    public class BusinessQualificationData
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<EconomicActivity> EconomicActivities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InformedRevenue InformedRevenue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public InformedPatrimony InformedPatrimony { get; set; }
    }
}
