using System.Text.Json.Serialization;

public partial class ProductModel
{
    [JsonPropertyName("Products")]
    public ProductResult ProductResults { get; set; }
    public string SearchQuery { get; set; } = "";
}

public partial class ProductResult
{
    public Product[] Products { get; set; }
    public object? ProductGroupId { get; set; }
    public long Start { get; set; }
    public long NumFound { get; set; }
}

public partial class Product
{
    public string TemplateName { get; set; }
    public Uri PrimaryImage { get; set; }
    public Availability Availability { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public string Brand { get; set; }
    public string SubCategory { get; set; }
    public string Url { get; set; }
    public string UnitPrice { get; set; }
    public double UnitPriceCalc { get; set; }
    public string UnitPriceLabel { get; set; }
    public bool DiscountItem { get; set; }
    public string Description { get; set; }
    public long SaleBeforeLastSalesDate { get; set; }
    public double Price { get; set; }
    public string[] Labels { get; set; }
    public bool? Favorite { get; set; }
    public string ProductSubGroupNumber { get; set; }
    public string ProductSubGroupName { get; set; }
    public string ProductCategoryGroupNumber { get; set; }
    public string ProductCategoryGroupName { get; set; }
    public string ProductMainGroupNumber { get; set; }
    public string ProductMainGroupName { get; set; }
}

public partial class Availability
{
    public bool IsDeliveryAvailable { get; set; }
    public bool IsAvailableInStock { get; set; }
}
