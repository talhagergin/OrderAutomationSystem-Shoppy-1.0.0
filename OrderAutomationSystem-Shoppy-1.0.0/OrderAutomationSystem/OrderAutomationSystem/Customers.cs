using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    public class Customers : ICustomers
    {
        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public IOrder Order { get; private set;}
        public int Balance { get; set; }
        public string Pass { get; private set; }
        public string Email { get; private set; }
        public string IsVerified { get; set; }
        public string VerifyCode { get; set; }
    

        public Customers(int CustomerID,string Email,string Name,string Surname,string Address,int Balance)
        {
            this.CustomerID = CustomerID;
            this.Name = Name;
            this.Surname = Surname;
            this.Address = Address;
            this.Balance = Balance;
            this.Email = Email;
           
        }
        public void setVerify(string IsVerified,string VerifyCode)
        {
            this.IsVerified = IsVerified;
            this.VerifyCode = VerifyCode;
        }
        public void takeOrder()
        {
            throw new NotImplementedException();
        }
    }
}
