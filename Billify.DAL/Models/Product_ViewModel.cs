using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billify.DAL.Models
{
    public class Product_ViewModel
    {
        public string name { get; set; }
        public bool status { get; set; }
        public List<Product_ViewModel> products { get; set; }
    }
}
