using System.Xml.Linq;
using System;
using System.Linq;
using System.Threading.Tasks;
using CarDealer.Data;
using System.Xml.Serialization;
using CarDealer.Models;
using System.IO;

namespace CarDealer
{
    public class StartUp
    {
        public static async Task Main(string[] args)
        {
            using (var db = new Data.CarDealerContext())
            {
                await db.Database.EnsureCreatedAsync();
                var xmlData = XDocument.Load("Datasets/suppliers.xml").ToString();

                ImportSuppliers(db, xmlData);
            }
        }


        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            var allElementsCollections = XElement.Parse(inputXml).Elements();
            var serilizer = new XmlSerializer(typeof(Supplier), new XmlRootAttribute("Supplier"));

            int suppliersCounter = 0;

                foreach (var element in allElementsCollections)
                {
                suppliersCounter++;
                  using (var str = new StringReader(element.ToString()))
                  {
                      Supplier supplier = (Supplier)serilizer.Deserialize(str);
                      context.Suppliers.Add(supplier);
                  }
                }
            context.SaveChanges();                             

            return $"Successfully imported {suppliersCounter}";
        }
    }
}