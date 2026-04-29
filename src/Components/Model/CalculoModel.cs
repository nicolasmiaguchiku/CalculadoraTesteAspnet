using System.ComponentModel.DataAnnotations;

namespace CalculadoraTeste.Components.Model
{
    public class CalculoModel
    {
        [Required(ErrorMessage = "O primeiro valor é obrigatório")]
        public int ValueA { get; set; }

        [Required(ErrorMessage = "O segundo valor é obrigatório")]
        public int ValueB { get; set; }
        public string Operation { get; set; } = string.Empty;
        public int Result { get; set; }
    }
}