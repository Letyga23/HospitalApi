using Microsoft.AspNetCore.Mvc;

namespace HospitalApi.Controllers
{
    public class Product
    {
        public string NameNameMedicine { get; set; }
        public string Warehouse { get; set; }
        public int Value { get; set; }
    }

    public class HospitalController : Controller
    {
        [HttpGet, Route("Apteka")]
        public IEnumerable<Product> GetTableData()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { NameNameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            products.Add(new Product { NameNameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            products.Add(new Product { NameNameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            products.Add(new Product { NameNameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });

            return products;
        }
    }
}
