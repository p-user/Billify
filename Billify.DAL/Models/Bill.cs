using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billify.DAL.Models
{
    [Table("bill")]
    public  class Bill
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client? client { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? issued_on { get; set; }
        public int? issued_by_userId { get; set; }
        public int? last_modified_by_userId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? last_modified_on { get; set; }
        public bool status { get; set; }
        public int? confirmed_by_userId { get; set; }
        public DateTime? confirmed_on { get; set; }
    }
}
