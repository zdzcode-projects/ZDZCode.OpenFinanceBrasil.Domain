﻿using System.ComponentModel;

namespace ZDZCode.OpenFinanceBrasil.Domain
{
    /// <summary>
    /// Determina se o Banco está comprando ou vendendo a moeda estrangeira nas operações spot, que se liquidam em até dois dias (não aplica-se a operações futuras. (Vide Enum) - Compra - Venda
    /// </summary>
    public enum EnumExchangeTransactionType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        COMPRA = 1,
        /// <summary>
        /// 
        /// </summary>
        [Description(" ")]
        VENDA = 2,
    }
}
