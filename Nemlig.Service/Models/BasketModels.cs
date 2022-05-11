   public partial class BasketModel
    {
        public Guid BasketGuid { get; set; }
        public Line[] Lines { get; set; }
        public string Email { get; set; }
        public long NumberOfProducts { get; set; }
        public long NumberOfBags { get; set; }
        public long NumberOfDeposits { get; set; }
        public long CouponDiscount { get; set; }
        public string FormattedDeliveryTime { get; set; }
        public string Notes { get; set; }
        public string UnattendedNotes { get; set; }
        public string PlacementMessage { get; set; }
        public long DoorCode { get; set; }
        public double TotalProductsPrice { get; set; }
        public double TotalBagsPrice { get; set; }
        public long TotalDepositsPrice { get; set; }
        public long DeliveryPrice { get; set; }
        public long TotalProductDiscountPrice { get; set; }
        public long NemligAccount { get; set; }
        public long CreditCardFee { get; set; }
        public long CreditCardId { get; set; }
        public double TotalPrice { get; set; }
        public double TotalPriceWithoutFee { get; set; }
        public bool IsMinTotalValid { get; set; }
        public long MinimumOrderTotal { get; set; }
        public bool IsMaxTotalValid { get; set; }
        public long MaximumOrderTotal { get; set; }
        public object MinimumAgeRequired { get; set; }
        public long OrderStepRequired { get; set; }
        public object[] OrdersToMergeWith { get; set; }
        public object[] ValidationFailures { get; set; }
        public long PaymentMethod { get; set; }
        public string TimeslotUtc { get; set; }
        public long DeliveryZoneId { get; set; }
        public bool HasTobaccoRestrictionProductCategories { get; set; }
        public object TobaccoBannerUrl { get; set; }
        public bool IsEkeyApplied { get; set; }
        public object SubscriptionId { get; set; }
        public bool IsSubscriptionBasket { get; set; }
        public string OrderTotalText { get; set; }
        public bool IsBackedByOrder { get; set; }
        public string BackedByOrderNumber { get; set; }
    }

    public partial class Line
    {
        public long Score { get; set; }
        public object ReplacementType { get; set; }
        public string MainGroupName { get; set; }
        public string CategoryPath { get; set; }
        public string ProductSubGroupNumber { get; set; }
        public string ProductSubGroupName { get; set; }
        public string ProductCategoryGroupNumber { get; set; }
        public string ProductCategoryGroupName { get; set; }
        public string ProductMainGroupNumber { get; set; }
        public string ProductMainGroupName { get; set; }
        public double ProductAddedTimestamp { get; set; }
        public double ItemPrice { get; set; }
        public long DiscountSavings { get; set; }
        public long Quantity { get; set; }
        public Uri PrimaryImage { get; set; }
        public object[] BundleItems { get; set; }
        public CheckoutHistoricalRecord CheckoutHistoricalRecord { get; set; }
        public object[] AlternativeProducts { get; set; }
        public object RemainingStock { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string SubCategory { get; set; }
        public string Url { get; set; }
        public string UnitPrice { get; set; }
        public long UnitPriceCalc { get; set; }
        public string UnitPriceLabel { get; set; }
        public bool DiscountItem { get; set; }
        public string Description { get; set; }
        public long SaleBeforeLastSalesDate { get; set; }
        public double Price { get; set; }
        public object Campaign { get; set; }
        public string[] Labels { get; set; }
        public bool Favorite { get; set; }
    }

    public partial class CheckoutHistoricalRecord
    {
        public long AvailabilityStatus { get; set; }
        public long OrderedQuantity { get; set; }
        public long AdjustedToQuantity { get; set; }
        public bool HasAlternativeProducts { get; set; }
    }