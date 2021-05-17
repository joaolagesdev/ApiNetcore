﻿
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ItemsSolicitationEntity : BaseEntity
    {
        public decimal Discount { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal TotalValue { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public Guid SolicitationId { get; set; }
        public ProductEntity Product { get; set; }
    }
}
