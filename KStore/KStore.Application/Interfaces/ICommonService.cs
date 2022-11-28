using System;
using System.Collections.Generic;
using System.Text;
using KStore.Application.ViewModels.Common;

namespace KStore.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
        SystemConfigViewModel GetSystemConfig(string code);
    }
}
