using FuelStation.Models;

namespace FuelStation.Blazor.Client.Shared {
    public class LedgerViewModel {
        public MonthEnum MonthEnum { get; set; }
        public byte Year { get; set; }
        public decimal Income { get; set; }
        public decimal Expences { get; set; }
        public decimal Total { get; set; }
    }
}
