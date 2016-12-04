using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.Enums.Cashier
{
    public enum PaymentType:byte
    {
        Cash = 1,
        Cheque = 2,
        Credit_Card = 3
    }

    public static class PaymentTypeExtensions
    {
        public static string ToText(this PaymentType voucherType)
        {
            return voucherType.ToString().Replace('_', ' ').Trim();
        }
    }
}
