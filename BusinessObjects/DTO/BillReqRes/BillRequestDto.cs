namespace BusinessObjects.DTO.Bill
{
    public class BillRequestDto
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public int CounterId { get; set; }
        public IEnumerable<BillItemRequestDto?>? Jewelries { get; set; }
        public IEnumerable<BillPromotionRequestDto?>? Promotions { get; set; }
    }
}