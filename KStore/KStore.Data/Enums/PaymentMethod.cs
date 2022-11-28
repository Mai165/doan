using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KStore.Data.Enums
{
    public enum PaymentMethod
    {
        [Description("Cash on delivery")]
        CashOnDelivery,
        [Description("Online Payment(VNPay)")]
        VNPay
    }
}
