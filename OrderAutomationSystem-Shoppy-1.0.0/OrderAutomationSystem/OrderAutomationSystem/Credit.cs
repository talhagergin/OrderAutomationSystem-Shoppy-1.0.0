using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace OrderAutomationSystem
{
    internal struct ExpDate
    {
        internal string year;
        internal string month;
    }
    internal class Credit : Payment
    {
        internal string Number { get; private set; }
        internal string Type { get; private set; }//Bu olmucak

        internal enum CardType
        {
            MasterCard, Visa, AmericanExpress, Discover, JCB, UnknownCard
        };



        internal ExpDate expdate;

        internal Credit(int amount, string number, ExpDate expDate) : base(amount)
        {
            Number = number;
            Type = getCardType(Number).ToString("g");
            expdate = expDate;
        }

        internal static CardType getCardType(string cardNumber)
        {
            if (Regex.Match(cardNumber, @"^4[0-9]{12}(?:[0-9]{3})?$").Success)
            {
                return CardType.Visa;
            }

            if (Regex.Match(cardNumber, @"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$").Success)
            {
                return CardType.MasterCard;
            }

            if (Regex.Match(cardNumber, @"^3[47][0-9]{13}$").Success)
            {
                return CardType.AmericanExpress;
            }

            if (Regex.Match(cardNumber, @"^6(?:011|5[0-9]{2})[0-9]{12}$").Success)
            {
                return CardType.Discover;
            }

            if (Regex.Match(cardNumber, @"^(?:2131|1800|35\d{3})\d{11}$").Success)
            {
                return CardType.JCB;
            }

            return CardType.UnknownCard;
        }

        public bool authorized()
        {
            return true;
        }
    }
}
