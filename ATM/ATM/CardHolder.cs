namespace ATM
{
    internal class CardHolder
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string CardNumber { get; set; }
        internal int Pin { get; set; }
        internal double Balance { get; set; }

        internal CardHolder(string firstName, string lastName, string cardNumber, int pin, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }
    }
}
