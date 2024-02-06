using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAR.Domain.Models;

namespace DemoAR.Domain.Interfaces
{
    internal interface IProductRepository
    {
        Task<List<Products>> GetProducts();
        Task<Products?> GetProducts(int productId);
    }
}
