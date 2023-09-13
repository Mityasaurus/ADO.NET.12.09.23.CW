using _12._09._23.CW.Warehouse;
using _12._09._23.CW.Warehouse.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._09._23.CW
{
    public class DatabaseAccess
    {
        private List<Product> _products;
        private List<Warehouse.Models.Type> _types;
        private List<Manufacturer> _manufacturers;

        public DatabaseAccess()
        {
            _products = GetTableData<Product>().ToList();
            _types = GetTableData<Warehouse.Models.Type>().ToList();
            _manufacturers = GetTableData<Manufacturer>().ToList();
        }

        private IEnumerable<T> GetTableData<T>() where T : class, IWarehouse
        {
            using(var context = new WarehouseContext())
            {
                var table = context.Set<T>();

                foreach(var item in table)
                {
                    yield return item;
                }
            }
        }
        private void PrintProducts(List<Product> products, int width)
        {
            Console.WriteLine($"{"ID".PadRight(width)}" +
                $"{"Name".PadRight(width)}" +
                $"{"TypeID".PadRight(width)}" +
                $"{"ManufacturerID".PadRight(width)}" +
                $"{"Number".PadRight(width)}" +
                $"{"CostPrice".PadRight(width)}" +
                $"{"Date".PadRight(width)}");

            Console.WriteLine();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.ID.ToString().PadRight(width)}" +
                    $"{product.Name.PadRight(width)}" +
                    $"{product.TypeID.ToString().PadRight(width)}" +
                    $"{product.ManufacturerID.ToString().PadRight(width)}" +
                    $"{product.Number.ToString().PadRight(width)}" +
                    $"{product.CostPrice.ToString().PadRight(width)}" +
                    $"{product.Date.ToString().PadRight(width)}");
            }
        }
        private void PrintTypes(List<Warehouse.Models.Type> types, int width)
        {
            Console.WriteLine($"{"ID".PadRight(width)}" +
                $"{"Name".PadRight(width)}");

            Console.WriteLine();

            foreach (var type in types)
            {
                Console.WriteLine($"{type.ID.ToString().PadRight(width)}" +
                    $"{type.Name.PadRight(width)}");
            }
        }
        private void PrintManufacturers(List<Manufacturer> manufacturers, int width)
        {
            Console.WriteLine($"{"ID".PadRight(width)}" +
                $"{"Name".PadRight(width)}");

            Console.WriteLine();

            foreach (var manufacturer in manufacturers)
            {
                Console.WriteLine($"{manufacturer.ID.ToString().PadRight(width)}" +
                    $"{manufacturer.Name.PadRight(width)}");
            }
        }

        public void PrintAllProducts()
        {
            PrintProducts(_products, 18);
        }
        public void PrintAllTypes()
        {
            PrintTypes(_types, 15);
        }
        public void PrintAllManufacturers()
        {
            PrintManufacturers(_manufacturers, 18);
        }
        public void PrintProductsMaxNumber()
        {
            int maxNumber = _products.Select(p => p.Number).Max();

            var resList = _products.Where(p => p.Number == maxNumber).ToList();

            PrintProducts(resList, 18);
        }
        public void PrintProductsMinNumber()
        {
            int minNumber = _products.Select(p => p.Number).Min();

            var resList = _products.Where(p => p.Number == minNumber).ToList();

            PrintProducts(resList, 18);
        }
        public void PrintProductsMaxCostPrice()
        {
            int maxCostPrice = _products.Select(p => p.CostPrice).Max();

            var resList = _products.Where(p => p.CostPrice == maxCostPrice).ToList();

            PrintProducts(resList, 18);
        }
        public void PrintProductsMinCostPrice()
        {
            int minCostPrice = _products.Select(p => p.CostPrice).Min();

            var resList = _products.Where(p => p.CostPrice == minCostPrice).ToList();

            PrintProducts(resList, 18);
        }
    }
}
