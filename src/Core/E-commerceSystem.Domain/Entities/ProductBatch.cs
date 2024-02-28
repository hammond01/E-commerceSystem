using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;

public class ProductionBatch : BaseEntities
{
    [Key]
    public Guid ProductionBatchID { get; set; }
    public Guid ProductID { get; set; }
    public int Quantity { get; set; }
    public string? ProductionBatchName { get; set; }
    public double PriceOfBatch { get; set; }
    public DateTime ManufactureDate { get; set; }
    public DateTime ExpiryDate { get; set; }
}
