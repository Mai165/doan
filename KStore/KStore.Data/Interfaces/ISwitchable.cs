using KStore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KStore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
