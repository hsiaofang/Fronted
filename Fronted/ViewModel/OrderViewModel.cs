public class OrderViewModel
{
    public int OrderId { get; set; }
    public string VendorName { get; set; } = string.Empty;
    public string BatchNumber { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
    public DateTime LastUpdated { get; set; }

    // 客戶資料
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerPhone { get; set; } = string.Empty;
    public string CustomerAddress { get; set; } = string.Empty;
    public string PickupStore { get; set; } = string.Empty;

    // 訂單明細
    public int Quantity { get; set; }
    public decimal TotalAmount { get; set; }
}
