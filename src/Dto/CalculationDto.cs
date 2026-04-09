namespace CalculadoraTeste.Dto
{
    public class CalculationDto
    {
        public int Id { get; set; }
        public int ValueA { get; set; }
        public int ValueB { get; set; }
        public string Operation { get; set; } = string.Empty;
        public int Result { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}