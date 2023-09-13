namespace _12._09._23.CW.Warehouse.Models
{
    public class Type : IWarehouse
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
