using System;
using System.Collections.Generic;
using System.Text;

namespace KStore.Application.ViewModels.Common
{
    public class TagViewModel
    {
        public string Id { set; get; }

        public string Name { set; get; }

        public string Type { set; get; }

        public bool IsNew { get; set; } = false;
    }
}
