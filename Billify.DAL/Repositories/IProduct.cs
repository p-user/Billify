using Billify.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billify.DAL.Repositories
{
    public interface IProduct
    {
        int create { get; set; }
        int delete { get; set; }
        int update { get; set; }
        List<Product_ViewModel> GetAllProducts();
        Product_ViewModel GetProductByCustomer();
    }
}
