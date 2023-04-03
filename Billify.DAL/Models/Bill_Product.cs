using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billify.DAL.Models
{
    [Table("bill_product")]
    public class Bill_Product
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("product")]
        public int product_Id { get; set; }
        public Product product { get; set; }
        [ForeignKey("bill")]
        public int bill_Id { get; set; }
        public Bill bill { get; set; }
        public int prd_quantity { get; set; }   
    }
}
