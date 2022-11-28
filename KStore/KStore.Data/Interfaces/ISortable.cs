using System;
using System.Collections.Generic;
using System.Text;

namespace KStore.Data.Interfaces
{
    public interface ISortable
    {
        int SortOrder { set; get; }
    }
}
