namespace BusinessObjects.Models;

/// <summary>
/// Lưu thông tin gem
/// </summary>
public class Gem
{
    public int GemId { get; set; }
    public string? Type { get; set; }
    public string? City { get; set; }
    public float BuyPrice { get; set; }
    public float SellPrice { get; set; }
    public DateTimeOffset LastUpdated { get; set; }

    public virtual ICollection<JewelryMaterial> JewelryMaterials { get; set; } = new List<JewelryMaterial>();
}