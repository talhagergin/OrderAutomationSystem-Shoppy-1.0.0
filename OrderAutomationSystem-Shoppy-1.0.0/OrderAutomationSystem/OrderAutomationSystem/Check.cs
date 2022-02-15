using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
    internal class Check:Payment
    {
        internal int BankID { get; private set; }
        internal string CheckName { get; private set; }

       internal Check(int amount,int bankID,string name,string surname) : base(amount)
        {
            BankID = bankID;
            this.CheckName = name;
            this.Name = name;
            this.Surname = surname;
        }

        public bool authorized()
        {
            return true;
        }

    }
}
