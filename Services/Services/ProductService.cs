using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Context;
using Entities;

namespace Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Guid Create(ProductDTO objectDTO)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            List<ProductDTO> products = new List<ProductDTO>(); 

            try
            {
                using (_unitOfWork)
                {
                    var productEntities = _unitOfWork.ProductRepository.GetAll();

                    if (productEntities.Any())
                    {
                        foreach (Product product in productEntities)
                        {
                            products.Add(MapProductEntityToDTO(product));
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return products;
        }

        public ProductDTO GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductDTO objectDTO)
        {
            throw new NotImplementedException();
        }

        private ProductDTO MapProductEntityToDTO(Product product)
        {
            if(product != null)
            {
                return new ProductDTO
                {
                    Id = product.Id,
                    Description = product.Description,
                    Name = product.Name,
                    ProductTypeId = product.ProductTypeId,
                    RegularPrice = product.RegularPrice
                };
            }

            return null;
        }
    }
}
