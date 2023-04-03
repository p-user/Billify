using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billify.DAL.Models
{
    [Table("product")]
    public  class Product
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public bool status { get; set; }
    }
}
