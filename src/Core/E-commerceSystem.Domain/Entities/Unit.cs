using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class Unit : BaseEntities
{
    [Key]
    public Guid UnitID { get; set; }
    public string? UnitName { get; set; }
}
