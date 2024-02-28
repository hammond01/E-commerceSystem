using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class StockInbound : BaseEntities
{
    [Key]
    public Guid InboundID { get; set; }
    public Guid WareHouseID { get; set; }
    public Guid ProductionBatchID { get; set; }
    public DateTime DateInbound { get; set; }
    public int QuantityInbound { get; set; }
    public double TotalPrice { get; set; }
    public string? Note { get; set; }
}
