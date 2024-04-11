
namespace SeoudBank.Entites.IContracts
{
    internal interface ICustomers
    {
        public Guid CustomerID { get; set; }
        public long CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string LandMark { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
    }
}
