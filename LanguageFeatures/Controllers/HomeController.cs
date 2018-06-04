using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //List<string> results = new List<string>();
            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    decimal? price = p?.Price ?? 0;
            //    string relatedName = p?.Related?.Name ?? "<None>";

            //    // results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
            //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            //}

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    { "Kayak", new Product { Name = "Kayak", Price = 275M } },
            //    { "Lifejacket", new Product{ Name = "Lifejacket", Price = 48.95M } }
            //};

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            //};

            //return View("Index", products.Keys);

            // return View(results);

            //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }
            //}
            //return View("Index", new string[] { $"Total: {total:C2}" });

            //ShoppingCart cart= new ShoppingCart { Products = Product.GetProducts() };
            //decimal cartTotal = cart.TotalPrices();
            //return View("Index", new string[] { $"Total: {cartTotal:C2}" });

            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();
            //decimal arrayTotalFiltered = productArray.FilterByPrice(20).TotalPrices();

            //decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

            //return View("Index", new string[] { $"Cart Total: {cartTotal:C2}", $"Array Total: {arrayTotal:C2}" });


            //bool FilterByPrice(Product p)
            //{
            //    return (p?.Price ?? 0) >= 20;
            //}

            //Func<Product, bool> nameFilter = delegate (Product prod) {
            //    return prod?.Name?[0] == 'S';
            //};

            //decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();
            //decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();

            //return View("Index", new string[] { $"Price Total: {priceFilterTotal:C2}", $"Name Total: {nameFilterTotal:C2}" });

           // return View(Product.GetProducts().Select(p => p?.Name));

            return View(productArray.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }

        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));

        //public async Task<ViewResult> Index()
        //{
        //    long? length = await MyAsyncMethods.GetPageLength();
        //    return View(new string[] { $"Length: {length}" });
        //}
    }
}