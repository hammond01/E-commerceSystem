using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class Category : BaseEntities
{
    [Key]
    public Guid CategoryID { get; set; }
    public string? CategoryName { get; set; }
    public string? Description { get; set; }
}
