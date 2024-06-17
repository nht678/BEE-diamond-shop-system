﻿namespace BusinessObjects.Models;

public class StonePrice
{
    public required string StonePriceId { get; set; }
    public string? Type { get; set; }
    public string? City { get; set; }
    public float BuyPrice { get; set; }
    public float SellPrice { get; set; }
    
    public DateTimeOffset LastUpdated { get; set; }
    
    public virtual ICollection<JewelryMaterial> JewelryMaterials { get; set; } = new List<JewelryMaterial>();
    public virtual ICollection<StoneMasterPrice> StoneMasterPrices { get; set; } = new List<StoneMasterPrice>();
}