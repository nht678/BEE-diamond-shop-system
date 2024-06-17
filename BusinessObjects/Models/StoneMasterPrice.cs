namespace BusinessObjects.Models;

public class StoneMasterPrice
{
    public required string StoneMasterPriceId { get; set; }
    public string? StonePriceId { get; set; }
    public float StoneStorePrice { get; set; }
    public virtual StonePrice? StonePrice { get; set; }
}