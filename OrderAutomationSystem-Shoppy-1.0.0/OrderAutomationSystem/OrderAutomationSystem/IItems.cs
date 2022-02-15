using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    public interface IItems
    {
        int ItemID { get; }
        string Name { get; set; }
        int Quantity { get; set; }
        int Weight { get; set; }
        string Description { get; set; }

    }
}
