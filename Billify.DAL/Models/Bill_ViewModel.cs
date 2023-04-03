using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billify.DAL.Models
{
    public class Bill_ViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string client_name { get; set; }
        public DateTime? issued_on { get; set; }
        public int? issued_by_userId { get; set; }
        public int? last_modified_by_userId { get; set; }
        public string last_modified_by_username { get; set; }
        public DateTime? last_modified_on { get; set; }
        public bool status { get; set; }
        public int? confirmed_by_userId { get; set; }
        public string confirmed_by_username { get; set; }
        public DateTime? confirmed_on { get; set; }
        public List<Bill_ViewModel> bill_list { get; set; } 
    }
}
