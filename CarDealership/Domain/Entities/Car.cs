namespace Domain.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Marke { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public bool IsSold { get; set; }
    }
}
