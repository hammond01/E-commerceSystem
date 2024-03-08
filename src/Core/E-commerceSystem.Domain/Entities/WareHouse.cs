using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class WareHouse : BaseEntities
{
    [Key]
    public Guid WareHouseID { get; set; }
    public string? WarehouseName { get; set; }
    public string? Address { get; set; }
    public string? Note { get; set; }
}
