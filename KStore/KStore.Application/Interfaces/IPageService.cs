using System;
using System.Collections.Generic;
using System.Text;
using KStore.Application.ViewModels.Blog;
using KStore.Utilities.Dtos;

namespace KStore.Application.Interfaces
{
    public interface IPageService : IDisposable
    {
        void Add(PageViewModel pageVm);

        void Update(PageViewModel pageVm);

        void Delete(int id);

        List<PageViewModel> GetAll();

        PagedResult<PageViewModel> GetAllPaging(string keyword, int page, int pageSize);

        PageViewModel GetByAlias(string alias);

        PageViewModel GetById(int id);

        PageViewModel GetSigleActive();

        void SaveChanges();

    }
}
