namespace CSharpEx.SimpleObjects
{
    public interface ICard
    {
        bool AuthorizePayment(int amount, int pin);

        bool ChangePin(int oldPin, int newPin);

        void Deactivate();
    }
}