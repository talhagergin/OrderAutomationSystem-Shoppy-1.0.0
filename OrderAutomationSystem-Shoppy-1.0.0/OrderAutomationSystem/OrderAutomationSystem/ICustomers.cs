using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    public interface ICustomers
    {
        int  CustomerID { get; }
        string Name { get; set; }
        string Surname { get; set; }
        string Address { get; set; }
        IOrder Order { get;}
        string Pass { get; }
        int Balance { get; set; }
        string Email { get; }


        void takeOrder();

    }
}
