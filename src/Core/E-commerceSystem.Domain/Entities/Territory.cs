using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class Territory : BaseEntities
{
    [Key]
    public Guid TerritoryID { get; set; }
    public Guid RegionID { get; set; }
    public string TerritoryDescription { get; set; } = null!;
}
