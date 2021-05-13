﻿using System;

namespace Domain.Dtos
{
    public class ProductUpdateResultDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}