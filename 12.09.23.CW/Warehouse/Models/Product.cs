namespace _12._09._23.CW.Warehouse.Models
{
    public class Product : IWarehouse
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public int TypeID { get; set; }

        public int ManufacturerID { get; set; }

        public int Number { get; set; }

        public int CostPrice { get; set; }

        public DateTime Date { get; set; }

        public virtual Type Type { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
