namespace AutoApi.Models
{
    public class Auto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public int Year { get; set; }

        public decimal Price { get; set; }
    }
}