namespace PA101App.Models
{
    internal class Product : BaseEntity
    {
        public string Name { get; set; }
        public string  Description { get; set; }
        public double  Price { get; set; }
    }
}
