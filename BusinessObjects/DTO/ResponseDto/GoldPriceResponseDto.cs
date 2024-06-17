﻿namespace BusinessObjects.DTO.ResponseDto;

public class GoldPriceResponseDto
{
    public required string GoldPriceId { get; set; }
    public string? Type { get; set; }
    public string? City { get; set; }
    public float BuyPrice { get; set; }
    public float SellPrice { get; set; }
    public DateTimeOffset? LastUpdated { get; set; }
}