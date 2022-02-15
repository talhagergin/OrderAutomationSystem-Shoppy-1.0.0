using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    public class OrderDetail : IOrderDetail
    {
        
        public List<Item> Items { get; set; }
        public string Address { get; set; }
        public int TotalAmount { get; set; }
        public OrderDetail()
        {

        }
        public OrderDetail(List<Item> Items,int TotalAmount)
        {
            this.Items = Items;
            this.TotalAmount = TotalAmount;
        }
        public void setDetail(List<Item> Items, int TotalAmount)
        {
            this.Items = Items;
            this.TotalAmount = TotalAmount;
        }

        public int calcTotalAmount()
        {
            throw new NotImplementedException();
        }

        public int calcTotalWeight()
        {
            throw new NotImplementedException();
        }
    }
}
