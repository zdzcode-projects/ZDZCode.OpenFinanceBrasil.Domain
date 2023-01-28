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
    public class BusinessFinancialRelationData
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
        public DateTime StartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<EnumProductServiceType> ProductsServicesType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<BusinessProcurator> Procurators { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public List<Account> Accounts { get; set; }
    }
}
