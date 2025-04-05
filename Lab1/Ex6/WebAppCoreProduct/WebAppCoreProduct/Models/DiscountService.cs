using System.Runtime.CompilerServices;

namespace WebAppCoreProduct.Models
{
    public class DiscountService:IDiscountService
    {
        public decimal? CalculateDiscount(decimal? originalPrice, double persDisc, string discountType)
        {
            return discountType switch
            {
                "regular" => originalPrice * (decimal?)persDisc,    // 10% скидка
                "personal" => originalPrice * (decimal?)persDisc / 100,   // персональная скидка
                "new year" => originalPrice * (decimal?)persDisc,   // 30% скидка                
                _ => originalPrice                    // без скидки
            };
        }
    }
}
