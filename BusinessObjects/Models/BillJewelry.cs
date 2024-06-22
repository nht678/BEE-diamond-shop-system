namespace BusinessObjects.Models;

/// <summary>
/// Chi tiết mặt hàng trang sức trong phiếu mua hàng
/// </summary>
public partial class BillJewelry
{
    public int BillJewelryId { get; set; }

    /// <summary>
    /// Đơn hàng
    /// </summary>
    public int BillId { get; set; }

    /// <summary>
    /// Trang sức
    /// </summary>
    public int JewelryId { get; set; }

    /// <summary>
    /// Số lượng
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Tiền công
    /// </summary>
    public double? LaborCost { get; set; }

    /// <summary>
    /// Tiền đá tại thời điểm bán
    /// </summary>
    public float GemSellPrice { get; set; }

    /// <summary>
    /// Tiền vàng tại thời điểm bán
    /// </summary>
    public float GoldSellPrice { get; set; }

    /// <summary>
    /// Trọng lượng vàng
    /// </summary>
    public float GoldWeight { get; set; }

    /// <summary>
    /// Số lượng đá
    /// </summary>
    public float StoneQuantity { get; set; }

    /// <summary>
    /// Đơn giá
    /// </summary>
    public double? Price { get; set; }

    /// <summary>
    /// Thành tiền [giá vàng thời điểm * trọng lượng sản phẩm] + tiền công + tiền đá 
    /// </summary>
    public double? TotalAmount { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }

    public virtual Bill? Bill { get; set; }
    public virtual Jewelry? Jewelry { get; set; }
}
