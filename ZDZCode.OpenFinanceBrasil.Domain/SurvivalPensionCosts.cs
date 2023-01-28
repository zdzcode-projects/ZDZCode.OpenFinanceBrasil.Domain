using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SurvivalPensionCosts { 

    /// <summary>
    /// Carregamento antecipado.
    /// </summary>
    [Required]
    public SurvivalPensionLoadingAntecipated LoadingAntecipated { get; set; }

    /// <summary>
    /// Carregamento postecipado.
    /// </summary>
    [Required]
    public SurvivalPensionLoadingLate LoadingLate { get; set; }
    }
}
