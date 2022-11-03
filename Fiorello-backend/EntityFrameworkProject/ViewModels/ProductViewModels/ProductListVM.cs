﻿namespace EntityFrameworkProject.ViewModels.ProductViewModels
{
    public class ProductListVM 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string MainImage { get; set; }
    }
}
