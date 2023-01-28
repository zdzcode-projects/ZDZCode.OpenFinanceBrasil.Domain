using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class ResponseUnarrangedAccountOverdraftInstalments
    {
        /// <summary>
        /// Conjunto de informações referentes ao prazo remanescente e às parcelas de uma operação de crédito de adiantamento a depositante
        /// </summary>
        [Required]
        public UnarrangedAccountOverdraftInstalmentsData Data { get; set; }

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
