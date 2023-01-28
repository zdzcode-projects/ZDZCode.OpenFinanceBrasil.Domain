using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Mutuamente exclusivo com o campo date. Este campo é obrigatório no caso de agendamento. Neste caso, o campo date não deve ser informado.
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Define a política de agendamento único.
        /// </summary>
        [Required]
        public Single Single { get; set; }
    }
}
