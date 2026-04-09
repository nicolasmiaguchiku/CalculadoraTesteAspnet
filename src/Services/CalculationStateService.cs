using CalculadoraTeste.Dto;

namespace CalculadoraTeste.Services;

public class CalculationStateService
{
    public List<CalculationDto> Calculations { get; } = new();
    private int _currentId = 1;

    public int NextId() => _currentId++;
}
