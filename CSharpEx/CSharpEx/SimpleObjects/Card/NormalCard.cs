using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.SimpleObjects
{
    public class NormalCard : ICard
    {
        public NormalCard(int defaultAmount, int defaultPin) {  }
        public void AddAmount(int amount) { throw new NotImplementedException(); }

        public bool ChangePin(int oldPin, int newPin) { throw new NotImplementedException(); }

        public void Deactivate() { throw new NotImplementedException(); }
        public bool AuthorizePayment(int amount, int pin) { throw new NotImplementedException(); }
    }
}
