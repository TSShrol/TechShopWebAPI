using AutoMapper;
using BAL.DTOs;
using BAL.Interface;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class IProductService : Interface.IProductService
    {
        private readonly TechShopDbContext _context;
        private readonly IMapper _mapper;

        public IProductService(TechShopDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public void Create(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();

        }

        public void Edit(ProductDTO product)
        {
            throw new NotImplementedException();

        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var products = _context.Products.Include(x => x.Category).ToList();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public ProductDTO? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
