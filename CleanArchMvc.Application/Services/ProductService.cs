using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Add(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.CreateAsync(product);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> GetProductCategory(int? id)
        {
            var product = await _productRepository.GetProductCategoryAsync(id);
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task Remove(int? id)
        {
            var product = _productRepository.GetByIdAsync(id).Result;
            await _productRepository.RemoveAsync(product);
        }

        public async Task Update(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.UpdateAsync(product);
        }
    }
}
