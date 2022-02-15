using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    internal class PaymentEvents:EventArgs
    {
        public bool Completed { get;  set; }
        public Order Order { get;  set; }
    }
}
