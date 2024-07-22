namespace BusinessObjects.DTO.Jewelry;

public class JewelryRequestDto
{
    public int JewelryTypeId { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Barcode { get; set; }
    public decimal? LaborCost { get; set; }
    public bool? IsSold { get; set; }
    public string? PreviewImage { get; set; }
    public int? WarrantyTime { get; set; }

    public JewelryMaterialRequestDto? JewelryMaterial { get; set; } = new JewelryMaterialRequestDto();
    public ICollection<JewelryCounterDTO>? JewelryCounters { get; set; } = [];
}

public class JewelryCounterDTO
{
    public int? JewelryCounterId { get; set; }
    public int? JewelryId { get; set; }
    public int? CounterId { get; set; }
    public string? CounterName { get; set; }
}