using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    public interface IOrderDetail
    {
        List<Item> Items { get; set; }
        int TotalAmount { get; set; }

        int calcTotalAmount();
        int calcTotalWeight();
    }
}
