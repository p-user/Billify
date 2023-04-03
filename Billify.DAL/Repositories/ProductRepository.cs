using Billify.DAL.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billify.DAL.Repositories
{
    public class ProductRepository
    {
        private readonly ILogger<ProductRepository> _logger;

        public ProductRepository(ILogger<ProductRepository> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
        }
        public int MyProperty { get; set; }
    }
}
