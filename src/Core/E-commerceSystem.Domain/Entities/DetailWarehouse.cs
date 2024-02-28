using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class DetailWarehouse : BaseEntities
{
    [Key]
    public Guid DetailWarehouseID { get; set; }
    public Guid WarehouseID { get; set; }
    public Guid ProductionBatchID { get; set; }
    public int ActualWarehouse { get; set; }
    public double CostPrice { get; set; }
    public string? Note { get; set; }
}
