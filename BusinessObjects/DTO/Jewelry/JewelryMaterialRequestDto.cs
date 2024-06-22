namespace BusinessObjects.DTO.Jewelry;

public class JewelryMaterialRequestDto
{
    public int GemId { get; set; }
    public int GoldId { get; set; }

    public float GoldQuantity { get; set; }
    public float GemQuantity { get; set; }
}