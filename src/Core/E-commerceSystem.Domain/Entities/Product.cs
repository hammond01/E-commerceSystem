using System.ComponentModel.DataAnnotations;
using E_commerceSystem.Domain.Entities.Base;

namespace E_commerceSystem.Domain.Entities;
public class Product : BaseEntities
{
    [Key]
    public Guid ProductID { get; set; }
    public Guid SupplierID { get; set; }
    public Guid CategoryID { get; set; }
    public Guid UnitID { get; set; }
    public string? ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsOnOrder { get; set; }
    public short ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
}
