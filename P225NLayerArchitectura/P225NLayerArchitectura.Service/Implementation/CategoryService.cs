using AutoMapper;
using P225NLayerArchitectura.Core;
using P225NLayerArchitectura.Core.Entities;
using P225NLayerArchitectura.Core.Repositories;
using P225NLayerArchitectura.Service.DTOs.CategoryDTOs;
using P225NLayerArchitectura.Service.Exceptions;
using P225NLayerArchitectura.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P225NLayerArchitectura.Service.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<CategoryListDto>> GetAllAsync()
        {
            List<CategoryListDto> categoryListDtos = _mapper.Map<List<CategoryListDto>>(await _unitOfWork.CategoryRepository.GetAllAsync(c => !c.IsDeleted));
            return categoryListDtos;
        }

        public async Task PostAsyn(CategoryPostDto categoryPostDto)
        {
            if ( await _unitOfWork.CategoryRepository.IsExistAsync(c => c.Name == categoryPostDto.Name))
                throw new AlreadyExistException($"Category Name Already Exist Name={categoryPostDto.Name}");

            Category category = _mapper.Map<Category>(categoryPostDto);

            await _unitOfWork.CategoryRepository.AddAsync(category);
            await _unitOfWork.CommitAsync();
        }
    }
}
