using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CSharpEx.SimpleObjects.Card
{
    [TestFixture]
    public class CommonCardTests
    {
        public static int DefaultAmount = 1000;
        public static int DefaultPin = 1234;
        public static int DefaultCredit = 200;

        public static IEnumerable<NormalCard> GetNormalCard()
        {
            yield return new NormalCard(DefaultAmount, DefaultPin);
        }

        public static IEnumerable<CreditCard> GetCreditCard()
        {
          var result = new CreditCard(DefaultAmount, DefaultPin);
            result.SetAcceptableCredit(DefaultCredit);
            yield return result;
        }



        [Test]
        [TestCaseSource(nameof(GetNormalCard))]
        [TestCaseSource(nameof(GetCreditCard))]
        public void AutorizePayment_true_Amount_LT_Defult(ICard card)
        {
            Assert.IsTrue(card.AuthorizePayment(300, DefaultPin));
        }

        [Test]
        [TestCaseSource(nameof(GetNormalCard))]
        [TestCaseSource(nameof(GetCreditCard))]
        public void AutorizePayment_true_Amount_EQ_Defult(ICard card)
        {
            Assert.IsTrue(card.AuthorizePayment(DefaultAmount, DefaultPin));
        }

        [Test]
        [TestCaseSource(nameof(GetNormalCard))]        
        public void AutorizePayment_false_Amount_GT_Defult(ICard card)
        {
            Assert.IsFalse(card.AuthorizePayment(1001, DefaultPin));
        }

        [Test]
        [TestCaseSource(nameof(GetNormalCard))]
        [TestCaseSource(nameof(GetCreditCard))]
        public void AutorizePayment_False_InvalidPin(ICard card)
        {
            Assert.IsFalse(card.AuthorizePayment(300, 8888));
        }

        [Test]
        [TestCaseSource(nameof(GetNormalCard))]
        [TestCaseSource(nameof(GetCreditCard))]
        public void AuthorizePayment_true_Multi(ICard card)
        {
            Assert.IsTrue(card.AuthorizePayment(100, DefaultPin), "first payment");
            Assert.IsTrue(card.AuthorizePayment(100, DefaultPin), "second payment");
            Assert.IsTrue(card.AuthorizePayment(100, DefaultPin), "third payment");
        }

        [Test]
        [TestCaseSource(nameof(GetNormalCard))]
        public void AuthorizePayment_false_AfterFull(ICard card)
        {
            Assert.IsTrue(card.AuthorizePayment(DefaultAmount, DefaultPin), "first payment");
            Assert.IsFalse(card.AuthorizePayment(100, DefaultPin), "second payment");
        }

        [Test]
        [TestCaseSource(nameof(GetCreditCard))]
        public void AuthorizePayment_Credit_true_AfterFull(ICard card)
        {
            Assert.IsTrue(card.AuthorizePayment(DefaultAmount, DefaultPin), "first payment");
            Assert.IsTrue(card.AuthorizePayment(100, DefaultPin), "second payment");
        }

        [Test]
        [TestCaseSource(nameof(GetCreditCard))]
        public void AuthorizePayment_Credit_false_Amount_GT_Credit(ICard card)
        {
            Assert.IsTrue(card.AuthorizePayment(DefaultAmount, DefaultPin), "first payment");
            Assert.IsFalse(card.AuthorizePayment(DefaultCredit + 10, DefaultPin), "second payment");
        }

        [Test]
        [TestCaseSource(nameof(GetNormalCard))]
        [TestCaseSource(nameof(GetCreditCard))]
        public void ChangePin_Works(ICard card)
        {
            int newPin = 5678;

            Assert.IsTrue(card.ChangePin(DefaultPin, newPin));

            Assert.IsFalse(card.AuthorizePayment(100, DefaultPin));
            Assert.IsTrue(card.AuthorizePayment(100, newPin));
        }

        [Test]
        [TestCaseSource(nameof(GetNormalCard))]
        [TestCaseSource(nameof(GetCreditCard))]
        public void ChangePin_false_InvalidOldPin(ICard card)
        {
            int newPin = 5678;

            Assert.IsFalse(card.ChangePin(8888, newPin));

            Assert.IsTrue(card.AuthorizePayment(100, DefaultPin));
            Assert.IsFalse(card.AuthorizePayment(100, newPin));
        }

        [Test]
        [TestCaseSource(nameof(GetNormalCard))]
        [TestCaseSource(nameof(GetCreditCard))]
        public void Deactivation_Authorize_false(ICard card)
        {
            card.Deactivate();

            Assert.IsFalse(card.AuthorizePayment(100,DefaultPin));
        }

        [Test]
        [TestCaseSource(nameof(GetNormalCard))]
        [TestCaseSource(nameof(GetCreditCard))]
        public void Deactivation_ChangePin_false(ICard card)
        {
            card.Deactivate();

            Assert.IsFalse(card.ChangePin(DefaultPin, DefaultPin));
        }
    }
}
