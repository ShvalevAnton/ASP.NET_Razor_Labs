namespace WebAppCoreProduct
{
    public interface IDiscountService
    {
        decimal CalculateDiscount(decimal originalPrice, decimal persDisc, string discountType);
    }
}
