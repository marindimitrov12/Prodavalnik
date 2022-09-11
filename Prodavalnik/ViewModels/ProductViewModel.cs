﻿using Prodavalnik.Models;

namespace Prodavalnik.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public string Description { get; set; }

        public IFormFile Img { get; set; }
       
        public Categories Category { get; set; }
    }
}
