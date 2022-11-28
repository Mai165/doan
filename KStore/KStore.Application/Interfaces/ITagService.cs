using KStore.Application.ViewModels.Common;
using KStore.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace KStore.Application.Interfaces
{
    public interface ITagService
    {
        void Add(TagViewModel pageVm);

        void Update(TagViewModel pageVm);

        void Delete(int id);

        List<TagViewModel> GetAll();

        PagedResult<TagViewModel> GetAllPaging(string keyword, int page, int pageSize);

        TagViewModel GetByAlias(string alias);

        TagViewModel GetById(int id);

        TagViewModel GetSigleActive();

        void SaveChanges();
    }
}
