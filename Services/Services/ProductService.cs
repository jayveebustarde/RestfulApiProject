using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Context;

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
            throw new NotImplementedException();
        }

        public ProductDTO GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductDTO objectDTO)
        {
            throw new NotImplementedException();
        }
    }
}
