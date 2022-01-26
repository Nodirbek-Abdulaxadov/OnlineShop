﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
