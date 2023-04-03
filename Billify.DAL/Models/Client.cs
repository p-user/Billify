﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billify.DAL.Models
{
    [Table("client")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        
    }
}
