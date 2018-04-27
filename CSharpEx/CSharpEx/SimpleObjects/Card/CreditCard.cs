using System;

namespace CSharpEx.SimpleObjects
{
    public class CreditCard : ICard
    {


        public CreditCard(int defaultAmount, int defaultPin)
        {

        }

        public void AddAmount(int amount) { throw new NotImplementedException(); }
        public void SetAcceptableCredit(int credit) { throw new NotImplementedException();}

        public bool ChangePin(int oldPin, int newPin) { throw new NotImplementedException(); }

        public void Deactivate() { throw new NotImplementedException(); }
        public bool AuthorizePayment(int amount, int pin) { throw new NotImplementedException(); }
    }
}