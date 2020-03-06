﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoroboShop.Models
{
    public class CategoryViewModelcs
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public int? ParentId { get; set; }
     
    }
}