﻿using BusinessObjects.DTO.Bill;

namespace BusinessObjects.DTO.BillReqRes
{
    public class BillResponseDto
    {
        public int BillId { get; set; }
        public string? CustomerName { get; set; }
        public string? StaffName { get; set; }
        public double TotalAmount { get; set; }
        public double TotalDiscount { get; set; }
        public DateTimeOffset? SaleDate { get; set; }
        public required List<BillItemResponse?> Items { get; set; }
        public required List<BillPromotionResponse?> Promotions { get; set; }
        public double AdditionalDiscount { get; set; }
        public int PointsUsed { get; set; }
        public double FinalAmount { get; set; }
    }
}