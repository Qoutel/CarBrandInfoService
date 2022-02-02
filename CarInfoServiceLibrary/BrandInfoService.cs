using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarInfoServiceLibrary
{
    public class BrandInfoService : IBrandInfoService
    {
        private List<CarBrand> _carBrands;
        public BrandInfoService()
        {
            _carBrands = new List<CarBrand>();
            _carBrands.Add(new CarBrand() { Name = "Tesla", Country = "USA", FoundedIn = 2003, NumberOfEmployees = 70757});
            _carBrands.Add(new CarBrand() { Name = "BMW", Country = "German", FoundedIn = 1917, NumberOfEmployees = 133778});
            _carBrands.Add(new CarBrand() { Name = "Audi", Country = "German", FoundedIn = 1909, NumberOfEmployees = 91674 });
            _carBrands.Add(new CarBrand() { Name = "Ferrari", Country = "Italy", FoundedIn = 1929, NumberOfEmployees = 4556 });
            _carBrands.Add(new CarBrand() { Name = "Kia", Country = "South Korea", FoundedIn = 1944, NumberOfEmployees = 52488 });
            _carBrands.Add(new CarBrand() { Name = "Mazda", Country = "Japan", FoundedIn = 1920, NumberOfEmployees = 46398 });
            _carBrands.Add(new CarBrand() { Name = "Ford", Country = "USA", FoundedIn = 1903, NumberOfEmployees = 199000 });
            _carBrands.Add(new CarBrand() { Name = "Volvo", Country = "Sweden", FoundedIn = 1927, NumberOfEmployees = 96194 });
        }
        public CarBrand GetInfo (string name)
        {
            return _carBrands.FirstOrDefault(b => b.Name == name);
        }
    }
}
