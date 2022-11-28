using AutoMapper;
using KStore.Application.Interfaces;
using KStore.Application.ViewModels.Common;
using KStore.Data.Entities;
using KStore.Infrastructure.Interfaces;
using KStore.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KStore.Application.Implementation
{
    public class TagService : ITagService
    {
        private IRepository<Tag, int> _tagRepository;
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TagService(IRepository<Tag, int> tagRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._tagRepository = tagRepository;
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(TagViewModel pageVm)
        {
            var page = _mapper.Map<TagViewModel, Tag>(pageVm);
            _tagRepository.Add(page);
        }

        public void Delete(int id)
        {
            _tagRepository.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<TagViewModel> GetAll()
        {
            return _mapper.ProjectTo<TagViewModel>(_tagRepository.FindAll()).ToList();
        }

        public PagedResult<TagViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _tagRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderByDescending(x => x.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            var paginationSet = new PagedResult<TagViewModel>()
            {
                Results = _mapper.ProjectTo<TagViewModel>(data).ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public TagViewModel GetByAlias(string alias)
        {
            return _mapper.Map<Tag, TagViewModel>(_tagRepository.FindSingle(x => x.Name == alias));
        }

        public TagViewModel GetById(int id)
        {
            return _mapper.Map<Tag, TagViewModel>(_tagRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(TagViewModel pageVm)
        {
            var page = _mapper.Map<TagViewModel, Tag>(pageVm);
            _tagRepository.Update(page);
        }

        public TagViewModel GetSigleActive()
        {
            return null;
        }
    }
}
