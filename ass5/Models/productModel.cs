﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ass5.Models
{
    public class productModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}