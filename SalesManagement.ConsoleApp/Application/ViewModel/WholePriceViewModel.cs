﻿namespace SalesManagement.ConsoleApp.Application.ViewModel
{
    public class WholePriceViewModel
    {
        public int Id { get; set; }
        
        public int ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }

        public virtual ProductViewModel Product { get; set; }
    }
}