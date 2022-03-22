﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Warehouse
    {
        [Key]
        [StringLength(70)]
        public string WarehouseId { get; set; }
        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }
        [Required]
        [StringLength(100)]
        public string WarehouseAddress { get; set; }

        //Relationship with Storage
        public ICollection<Storage> Storages { get; set; }
    }
}