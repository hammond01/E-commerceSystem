using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class EmployeeTerritory : BaseEntities
{
    [Key]
    public Guid EmployeeID { get; set; }
    public Guid TerritoryID { get; set; }
}
