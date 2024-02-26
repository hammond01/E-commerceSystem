namespace E_commerceSystem.Domain.Entities;
public class Territory
{
    public string TerritoryID { get; set; } = null!;
    public string TerritoryDescription { get; set; } = null!;
    public int RegionID { get; set; }
}
