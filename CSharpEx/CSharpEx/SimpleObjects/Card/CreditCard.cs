using System;

namespace CSharpEx.SimpleObjects
{
    public class CreditCard : NormalCard, ICard
    {


        public CreditCard(int defaultAmount, int defaultPin) : base(defaultAmount, defaultPin)
        {

        }

        private int Credit { get; set; }
        public void SetAcceptableCredit(int defaultCredit) { Credit = defaultCredit; }

        public override bool AuthorizePayment(int amount, int pin)
        {
            if (false == CheckPin(pin))
            {
                return false;
            }

            if (Amount + Credit < amount)
            {
                return false;
            }

            Amount -= amount;

            return true;
        }
    }
}