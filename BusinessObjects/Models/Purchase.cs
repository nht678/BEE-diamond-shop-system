using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

/// <summary>
/// Mua hàng của khách hàng
/// </summary>
public partial class Purchase
{
    public int PurchaseId { get; set; }
    /// <summary>
    /// người mua, người bán 
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Người mua
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Trạng sức
    /// </summary>
    public int JewelryId { get; set; }

    public DateTimeOffset? PurchaseDate { get; set; }
    public double? PurchasePrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int IsBuyBack { get; set; }

    public virtual Customer? Customer { get; set; }
    public virtual Jewelry? Jewelry { get; set; }
    [JsonIgnore]
    public virtual User? User { get; set; }
}
