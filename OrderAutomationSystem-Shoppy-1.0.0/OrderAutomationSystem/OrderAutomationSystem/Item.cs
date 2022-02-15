using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OrderAutomationSystem
{
    public class Item : IItems
    {   
        public int ItemID { get; private set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        internal int Amount { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Tag { get; set; }
        public Image Picture { get; set; }

       
        public Item(int ItemID,string Name,int Quantity,int Weight,string Description,int Price,string Tag)
        {  
            this.ItemID = ItemID;
            this.Name = Name;
            this.Quantity = Quantity;
            this.Weight = Weight;
            this.Description = Description;
            this.Price = Price;
            this.Tag = Tag;
            this.Amount = 1;


        }

        public override string ToString()
        {
            return this.Name;
        }
    } 
}
