namespace AutopartsEntity.Catalog.ViewModels.CurrencyViewModel
{
    public class CurrencyCreateVM
    {
        public int NumericCurrencyCode { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public string CurrencyName { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}