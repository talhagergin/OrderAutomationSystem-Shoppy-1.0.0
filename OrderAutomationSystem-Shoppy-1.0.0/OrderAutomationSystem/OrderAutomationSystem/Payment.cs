using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    abstract internal class Payment
    {
        internal int Amount { get; set; }
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal Payment(int amount)
        {
            Amount = amount;
        }
    }
}
