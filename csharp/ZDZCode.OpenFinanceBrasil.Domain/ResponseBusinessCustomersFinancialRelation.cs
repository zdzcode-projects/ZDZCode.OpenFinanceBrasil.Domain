using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseBusinessCustomersFinancialRelation //data, confirmar com o Zids.
    {
        /// <summary>
        /// Objeto que reúne as informações relativas ao relacionamento do cliente junto à Instituição. Considera-se relacionamento as informações que permitam conhecer desde quando a pessoa consultada é cliente da instituição, bem como um indicador dos produtos e serviços que ela consome atualmente e seus representantes
        /// </summary>
        [Required]
        public BusinessFinancialRelationData Data { get; set; }

        /// <summary>
        /// Referências para outros recusos da API requisitada.
        /// </summary>
        [Required]
        public Links Links { get; set; }

        /// <summary>
        /// Meta informações referente à API requisitada.
        /// </summary>
        [Required]
        public Meta Meta { get; set; }
    }
}
