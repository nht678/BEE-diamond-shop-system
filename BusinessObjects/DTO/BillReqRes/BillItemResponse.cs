namespace BusinessObjects.DTO.Bill;

public class BillItemResponse
{
    public int JewelryId { get; set; }
    public string? Name { get; set; }
    public double JewelryPrice { get; set; }
    public double? LaborCost { get; set; }
    public double TotalPrice { get; set; }
}