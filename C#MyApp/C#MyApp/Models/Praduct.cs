using System.Security.Cryptography.X509Certificates;

namespace C_MyApp.Models
{
    internal class Praduct : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
