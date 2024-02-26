﻿namespace E_commerceSystem.Domain.Entities
{
    public class ProductionBatch
    {
        public int ProductionBatchID { get; set; }
        public string? ProductionBatchName { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double PriceOfBatch { get; set; }
        public int UnitID { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}

