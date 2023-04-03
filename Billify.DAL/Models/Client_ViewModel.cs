using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billify.DAL.Models
{
    public class Client_ViewModel
    {
        public string name { get; set; }
        public List<Client_ViewModel> clients { get; set; }
    }
}
