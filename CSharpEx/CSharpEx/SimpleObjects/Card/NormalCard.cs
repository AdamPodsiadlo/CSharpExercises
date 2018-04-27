using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.SimpleObjects
{
    public class NormalCard : ICard
    {
        private int Pin { get; set; }
        protected int Amount { get; set; }

        public NormalCard(int defaultAmount, int defaultPin)
        {
            Amount = defaultAmount;
            Pin = defaultPin;
        }

        protected bool CheckPin(int pin)
        {
            return Pin == pin;
        }
        public void AddAmount(int amount) { throw new NotImplementedException(); }

        public bool ChangePin(int oldPin, int newPin)
        {
            if (false == CheckPin(oldPin))
            {
                return false;
            }

            Pin = newPin;
            return true;
        }

        public void Deactivate() { Pin = int.MinValue; }

        public virtual bool AuthorizePayment(int amount, int pin)
        {
            if (false == CheckPin(pin))
            {
                return false;
            }

            if (Amount < amount)
            {
                return false;
            }

            Amount -= amount;
            return true;
        }
    }
}
