namespace BusinessObjects.Models;

public class GoldMasterPrice
{
    public required string GoldMasterPriceId { get; set; }
    public string? GoldPriceId { get; set; }
    public float GoldStorePrice { get; set; }
    public virtual GoldPrice? GoldPrice { get; set; }
    
}