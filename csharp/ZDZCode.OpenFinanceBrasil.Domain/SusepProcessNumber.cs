using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    public class SusepProcessNumber
    {
        /// <summary>
        /// Sequência numérica utilizada para consulta dos processos eletrônicos na SUSEP, com caracteres especiais, conforme campo de consulta no site da SUSEP (XXXXX.XXXXXX/XXXX-XX) Observação: Mascaras da SUSEP – Serão permitidos todas as máscaras de Produtos.Limitar pelos códigos das Máscaras.
        /// </summary>
        [Required]
        public string SUSEP { get; set; }
    }
}
