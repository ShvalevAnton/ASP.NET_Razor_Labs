using System.Runtime.CompilerServices;

namespace WebAppCoreProduct.Models
{
    public class DiscountService:IDiscountService
    {
        public decimal CalculateDiscount(decimal originalPrice, decimal persDisc, string discountType)
        {
            return discountType switch
            {                
                "regular" => originalPrice * 0.18m,    // 10% скидка
                "personal" => originalPrice * persDisc / 100,   // персональная скидка               
                "new year" => originalPrice * 0.3m,   // 30% скидка
                _ => originalPrice                    // без скидки
            };

        }
    }
}
