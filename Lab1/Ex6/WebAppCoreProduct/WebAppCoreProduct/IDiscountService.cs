namespace WebAppCoreProduct
{
    public interface IDiscountService
    {
        decimal? CalculateDiscount(decimal? originalPrice, double persDisc, string discountType);
    }
}
