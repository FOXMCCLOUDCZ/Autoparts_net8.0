using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.ManufacturerViewmodel;
using AutopartsRepository.Repositories.Interfaces;
using AutopartsRepository.UnitOfWorks.Interfaces;
using AutopartsService.Services.Catalog.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutopartsService.Services.Catalog.Implementations
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Manufacturer> _repository;

        public ManufacturerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Manufacturer>();
        }

        public async Task<List<ManufacturerListVM>> AllListAsync()
        {
            var manufacturerListVM = await _unitOfWork.GetGenericRepository<Manufacturer>().ListEntity()
                .ProjectTo<ManufacturerListVM>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return manufacturerListVM;
        }

        public async Task CreateManufacturerAsync(ManufacturerCreateVM request)
        {
            var manufacturer = _mapper.Map<Manufacturer>(request);
            await _repository.CreateEntity(manufacturer);
            await _unitOfWork.CommitAsync();

        }

        public async Task DeleteManufacturerAsync(int id)
        {
            var manufacturer = await _repository.FindEntity(id);
            _repository.DeleteEntity(manufacturer);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ManufacturerEditVM> GetManufacturerById(int id)
        {
            var manufacturer = await _repository.Where(x => x.Id == id)
                .ProjectTo<ManufacturerEditVM>(_mapper.ConfigurationProvider)
                .SingleAsync();
            return manufacturer;
        }

        public async Task EditManufacturerAsync(ManufacturerEditVM request)
        {
            var manufacturer = _mapper.Map<Manufacturer>(request);
            _repository.EditEntity(manufacturer);
            await _unitOfWork.CommitAsync();
        }
    }
}