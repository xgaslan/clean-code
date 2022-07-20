namespace OpenClosed.WithoutOpenClosed
{
    public abstract class BaseCar
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Door { get; set; }
        public int Tyre { get; set; }
        public double FuelUsagePerKM { get; set; }
    }
}