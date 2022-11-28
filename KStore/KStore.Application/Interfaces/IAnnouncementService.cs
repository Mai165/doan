using System;
using System.Collections.Generic;
using System.Text;
using KStore.Application.ViewModels.System;
using KStore.Data.Entities;
using KStore.Infrastructure.Interfaces;
using KStore.Utilities.Dtos;

namespace KStore.Application.Interfaces
{
    public interface IAnnouncementService
    {
        PagedResult<AnnouncementViewModel> GetAllUnReadPaging(Guid userId, int pageIndex, int pageSize);

        bool MarkAsRead(Guid userId, string id);
    }
}
