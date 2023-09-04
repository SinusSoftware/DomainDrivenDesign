namespace DomainDrivenDesign.Dekra
{
    public interface IDekraAdaptor
    {
        Task<RawDekraCalculationResult> GetDekraCalculationAsync(string zip);
    }
}
