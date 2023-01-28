using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class BankingAgentsStandard
    {
        /// <summary>
        /// Em formato texto, seguindo o domínio apresentado, devem ser colocados os dias da semana.
        /// </summary>
        [Required]
        public EnumWeekDay Weekday { get; set; }

        /// <summary>
        /// Horário padrão de início de atendimento pelo Correspondente Bancário. (Uma string que representa a hora conforme especificação RFC-3339, sempre com a utilização de timezone UTC(UTC time format). p.ex. '10:00:57Z').
        /// </summary>
        [Required]
        public string OpeningTime { get; set; }

        /// <summary>
        /// Horário padrão de encerramento de atendimento pelo Correspondente Bancário. (Uma string que representa a hora conforme especificação RFC-3339, sempre com a utilização de timezone UTC(UTC time format). p.ex. '16:00:57Z').
        /// </summary>
        [Required]
        public string ClosingTime { get; set; }
    }
}
