using System;

namespace Domain
{
    public class Floorsheets
    {
        private Int64 SerialNumber { get; set; }
        private Guid ContractNumber { get; set; }
        private string? Symbol { get; set; }
        private int BuyerBrokerCode { get; set; }
        private int SellerBrokerCode { get; set; }
        private string? ClientName { get; set; }
        private string? ClientCode { get; set; }
        private int Quantity { get; set; }
        private decimal Rate { get; set; }
        private decimal Amount { get; set; }
        private decimal StockCommision { get; set; }
        private decimal BankDeposit { get; set; }
    }
}
