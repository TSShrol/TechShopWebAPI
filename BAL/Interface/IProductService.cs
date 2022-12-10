using BAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Interface
{
    internal interface IProductService
    {
        IEnumerable<ProductDTO> GetAll();
        ProductDTO? GetById(int id);
        void Create(ProductDTO product);
        void Edit(ProductDTO product);
        void Delete(int id);
    }
}
