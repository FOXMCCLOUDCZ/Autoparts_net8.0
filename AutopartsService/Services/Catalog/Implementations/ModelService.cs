using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.ModelViewModel;
using AutopartsRepository.Repositories.Interfaces;
using AutopartsRepository.UnitOfWorks.Interfaces;
using AutopartsService.Services.Catalog.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutopartsService.Services.Catalog.Implementations
{
    public class ModelService : IModelService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Model> _repository;

        public ModelService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Model>();
        }

        public async Task<List<ModelListVM>> AllListAsync()
        {
            var modelListVM = await _unitOfWork.GetGenericRepository<Model>().ListEntity()
                .ProjectTo<ModelListVM>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return modelListVM;
        }

        public async Task CreateModelAsync(ModelCreateVM request)
        {
            var model = _mapper.Map<Model>(request);
            await _repository.CreateEntity(model);
            await _unitOfWork.CommitAsync();

        }

        public async Task DeleteModelAsync(int id)
        {
            var model = await _repository.FindEntity(id);
            _repository.DeleteEntity(model);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ModelEditVM> GetModelById(int id)
        {
            var model = await _repository.Where(x => x.Id == id)
                .ProjectTo<ModelEditVM>(_mapper.ConfigurationProvider)
                .SingleAsync();
            return model;
        }

        public async Task EditModelAsync(ModelEditVM request)
        {
            var model = _mapper.Map<Model>(request);
            _repository.EditEntity(model);
            await _unitOfWork.CommitAsync();
        }
    }
}