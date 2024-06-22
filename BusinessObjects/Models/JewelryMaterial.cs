namespace BusinessObjects.Models;

/// <summary>
/// Nguyên liệu của trang sức
/// </summary>
public class JewelryMaterial
{
    public int JewelryMaterialId { get; set; }
    /// <summary>
    /// ID trang sức
    /// </summary>
    public int JewelryId { get; set; }

    /// <summary>
    /// GoldId
    /// </summary>
    public int GoldId { get; set; }

    /// <summary>
    /// GemId
    /// </summary>
    public int GemId { get; set; }

    /// <summary>
    /// Trọng lượng vàng
    /// </summary>
    public float GoldWeight { get; set; }

    /// <summary>
    /// Số lượng đá
    /// </summary>
    public float StoneQuantity { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public virtual Gem? Gem { get; set; }
    public virtual Gold? Gold { get; set; }
    public virtual Jewelry? Jewelry { get; set; }
}