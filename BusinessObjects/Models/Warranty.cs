namespace BusinessObjects.Models;

/// <summary>
/// Phiếu bảo hành
/// </summary>
public partial class Warranty
{
    public int WarrantyId { get; set; }

    public int JewelryId { get; set; }

    public string? Description { get; set; }

    public DateTimeOffset? EndDate { get; set; }
    public Jewelry? Jewelry { get; set; }
}
