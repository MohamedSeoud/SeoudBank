using SeoudBank.Entites.IContracts;
using SeoudBank.Exceptions;

namespace SeoudBank.Entites.Contracts
{
    public class Customer : ICustomers,ICloneable
    {
        #region privateFields
        private long _customerCode;
        private string _customerName;
        private string _mobile;
        #endregion
        #region Properties
        public Guid CustomerID { get; set; }
        public string Address { get; set; }
        public string LandMark { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        #endregion
        #region propertyFields
        public long CustomerCode
        {
            get => _customerCode;
            set
            {
                if (value > 0)
                {
                    _customerCode = value;
                }
                else
                {
                    throw new CustomerException("Customer code can't be negative value");
                }
            }
        }
        public string CustomerName
        {
            get => _customerName;
            set
            {
                if (value.Length > 10 && !string.IsNullOrEmpty(value))
                {
                    _customerName = value;
                }
                else
                {
                    throw new CustomerException("Customer name should be more than 10 characters.");
                }
            }
        }
        public string Mobile
        {
            get => _mobile;
            set
            {
                if (value.Length > 10 && !string.IsNullOrEmpty(value))
                {
                    _mobile = value;
                }
                else
                {
                    throw new CustomerException("Mobile number should be equal 10 digits.");
                }
            }
        }

        #endregion
        #region Methods
        public object Clone()
        {
            return new Customer() { CustomerID=this.CustomerID, Address =this.Address, LandMark =this.LandMark,
            City=this.City, Country=this.Country,CustomerCode=this.CustomerCode,CustomerName= this.CustomerName,
            Mobile=this.Mobile
            };
        }
        #endregion
    }
}
