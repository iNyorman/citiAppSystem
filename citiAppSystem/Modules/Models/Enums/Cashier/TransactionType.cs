using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.Enums.Cashier
{
    public enum TransactionType:byte
    {
        DOWN = 1,
        INSTALLMENT = 2,
        MISC = 3,
        COD = 4
    }

    public static class TransactionTypeExtensions
    {
        public static string ToText(this TransactionType voucherType)
        {
            return voucherType.ToString().Replace('_', ' ').Trim();
        }
    }
}
