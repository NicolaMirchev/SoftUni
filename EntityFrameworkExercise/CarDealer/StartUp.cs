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
                var xmlData = XDocument.Load("Datasets/cars.xml").ToString();



                GetCarsWithDistance(db);
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

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            var allElementsCollections = XElement.Parse(inputXml).Elements();
            var serilizer = new XmlSerializer(typeof(Part), new XmlRootAttribute("Part"));

            int partsCount = 0;

            foreach (var element in allElementsCollections)
            {
                partsCount++;
                using (var str = new StringReader(element.ToString()))
                {
                    Part part = (Part)serilizer.Deserialize(str);
                    context.Parts.Add(part);
                }
            }
            context.SaveChanges();

            return $"Successfully imported {partsCount}";
        }
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            var allElementsCollections = XElement.Parse(inputXml).Elements();
            var serilizer = new XmlSerializer(typeof(Car), new XmlRootAttribute("Car"));

            int carsCounter = 0;

            foreach (var element in allElementsCollections)
            {
                carsCounter++;
                using (var str = new StringReader(element.ToString()))
                {                    
                    Car car = (Car)serilizer.Deserialize(str);

                    var partsAsXml = element.Elements("parts");

                    foreach (var part in partsAsXml)
                    {
                        Console.WriteLine(part.Element("partId").Attribute("id").Value);
                        car.PartCars.Add(new PartCar()
                            { CarId = carsCounter, 
                            PartId = int.Parse(part.Element("partId").Attribute("id").Value) });
 
                    }

                    context.Cars.Add(car);
                }
            }
            context.SaveChanges();

            return $"Successfully imported {carsCounter}";
        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            var allElementsCollections = XElement.Parse(inputXml).Elements();
            var serilizer = new XmlSerializer(typeof(Customer), new XmlRootAttribute("Customer"));

            int customersCounter = 0;

            foreach (var element in allElementsCollections)
            {
                customersCounter++;
                using (var str = new StringReader(element.ToString()))
                {
                    Customer customer = (Customer)serilizer.Deserialize(str);
                    context.Customers.Add(customer);
                }
            }
            context.SaveChanges();

            return $"Successfully imported {customersCounter}";
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            var allElementsCollections = XElement.Parse(inputXml).Elements();
            var serilizer = new XmlSerializer(typeof(Sale), new XmlRootAttribute("Sale"));

            int salesCounter = 0;

            foreach (var element in allElementsCollections)
            {
                salesCounter++;
                using (var str = new StringReader(element.ToString()))
                {
                    Sale sale = (Sale)serilizer.Deserialize(str);
                    context.Sales.Add(sale);
                }
            }
            context.SaveChanges();

            return $"Successfully imported {salesCounter}";
        }

        public static void GetCarsWithDistance(CarDealerContext context)
        {
            var serializer = new XmlSerializer(typeof(Car));

            var carsToSerialize = context.Cars.Where(c => c.TravelledDistance > 2000000)
                                              .OrderBy(c => c.Make).ThenBy(c => c.Model)
                                              .ToArray();

            using (var strinWriter = new StringWriter())
            {

              for (int i = 0; i < carsToSerialize.Count(); i++)
              {
                  if (i > 9)
                  {
                      break;
                  }
       
                  serializer.Serialize(strinWriter, carsToSerialize[i]);
              }



                Console.WriteLine( strinWriter.ToString());
            }
             
        
        

        }
    }
}