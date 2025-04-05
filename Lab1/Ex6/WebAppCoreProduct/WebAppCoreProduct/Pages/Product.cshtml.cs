using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {


        public Product Product { get; set; }
        public string? MessageRezult { get; private set; }
        private readonly IDiscountService _discountService;       

        // ��������� ����������� ����� �����������
        public ProductModel(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        public void OnGet()
        {
            MessageRezult = "��� ������ ����� ���������� ������";
        }

        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "�������� ������������ ������. ��������� ����";
                return;
            }
            double discount = 0.18;
            var result = _discountService.CalculateDiscount(price, discount, DiscountType.Regular);            
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";
            Product.Price = price;
            Product.Name = name;
        }

        public void OnPostDiscont(string name, decimal? price, double discont)
        {
            Product = new Product();
            var result = _discountService.CalculateDiscount(price, discont, DiscountType.Personal);
            MessageRezult = $"��� ������ {name} � ����� {price} � ������� {discont} ��������� {result}";
            Product.Price = price;
            Product.Name = name;
        }

        public void OnPostDiscNY(string name, decimal? price)
        {
            Product = new Product();
            double discont = 30;
            var result = _discountService.CalculateDiscount(price, discont, DiscountType.NewYear);
            MessageRezult = $"��� ������ {name} � ����� {price} � ������� {discont} ��������� {result}";
            Product.Price = price;
            Product.Name = name;
        }
    }
}
