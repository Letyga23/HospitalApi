using Microsoft.AspNetCore.Mvc;

namespace HospitalApi.Controllers
{
    public class Medicines
    {
        public string NameMedicine { get; set; }
        public string Warehouse { get; set; }
        public int Value { get; set; }
    }

    public class HospitalController : Controller
    {
        [HttpGet, Route("Apteka")]
        public IEnumerable<Medicines> GetTableData()
        {
            List<Medicines> medicines = new List<Medicines>();

            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Аджисепт", Warehouse = "Склад в поле", Value = 100 });
            medicines.Add(new Medicines { NameMedicine = "Грамидин", Warehouse = "Склад в городе", Value = 400 });
            medicines.Add(new Medicines { NameMedicine = "Гексарал спрей", Warehouse = "Склад за городом", Value = 250 });
            medicines.Add(new Medicines { NameMedicine = "Альмагель А", Warehouse = "Склад за городом", Value = 250 });


            return medicines;
        }
    }
}
