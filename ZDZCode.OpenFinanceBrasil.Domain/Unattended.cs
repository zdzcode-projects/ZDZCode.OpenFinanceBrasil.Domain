using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class Unattended
    {
        /// <summary>
        /// Tempo médio de resposta em milissegundos para chamadas no dia atual.
        /// </summary>
        [Display(Name = "Tempo médio de resposta em milissegundos para chamadas no dia atual")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public int CurrentDay { get; set; }

        /// <summary>
        /// Tempo médio de resposta em milissegundos para chamadas nos dias anteriores. O primeiro item do array é referente a ontem, e assim por diante. Devem ser retornados no máximo sete dias caso estejam disponíveis.
        /// </summary>
        [Display(Name = "Tempo médio de resposta em milissegundos para chamadas nos dias anteriores")]
        [Required]
        [MaxLength(160000)]
        [StringLength(160000)]
        [MinLength(2)]
        public List<int> PreviousDays { get; set; }
        //confirmar com o Zids esse "List"
    }
}
