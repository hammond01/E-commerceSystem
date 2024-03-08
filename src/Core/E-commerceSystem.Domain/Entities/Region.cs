using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class Region : BaseEntities
{
    [Key]
    public int RegionID { get; set; }
    public string RegionDescription { get; set; } = null!;
}
