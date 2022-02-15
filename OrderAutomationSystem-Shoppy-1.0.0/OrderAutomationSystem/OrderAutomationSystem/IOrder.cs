using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    [Flags] public enum PayWith
    {
        None   = 0,
        Credit = 1,
        Cash   = 2,
        Check  = 4
    }
   
    public enum Status {
    Enroute,//Yolda
    OnHold,//Market için Beklemede(item 0 ise)
    OnCargo,//Kargoda
    WaitForCargo//Kargo için bekleniyor(İtem 0 değilse bu olucak başlangıç için)
    }
    public interface IOrder
    {
        int OrderID { get; }
        DateTime Date { get; set; }
        Status State { get; set; }
        OrderDetail Details { get; set; }
        
    }
}
