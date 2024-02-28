using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class Shipper : BaseEntities
{
    [Key]
    public Guid ShipperID { get; set; }
    public string? CompanyName { get; set; }
    public string? Phone { get; set; }
}
