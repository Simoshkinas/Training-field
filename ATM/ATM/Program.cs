namespace ATM
{
    //Unfinished
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Main Operation
            bool atmStop = false;
            do 
            {
                var users = new List<CardHolder>();
                Console.WriteLine("Welcome to the ATM");
                Console.WriteLine("Choose the following option: ");
                BasicCommands.DisplayOptionsStart();
                var enteredCommand = BasicCommands.GetFirstOptions();
                switch(enteredCommand)
                {
                    case "A":
                        Console.WriteLine("Enter your first name:");
                         var firstName = BasicCommands.GetText().ToUpper();
                        Console.WriteLine("Enter your last name:");
                         var lastName = BasicCommands.GetText().ToUpper();
                        Console.WriteLine("enter your card number:");
                         var cardNumber = BasicCommands.GetText().ToUpper();
                        Console.WriteLine("Enter your PIN:");
                         var pin = BasicCommands.GetPin();
                        Console.WriteLine("Enter your balance:");
                         var balance = BasicCommands.GetBalance();
                        var cardHolder = new CardHolder(firstName, lastName, cardNumber, pin, balance);
                        users.Add(cardHolder);
                        break;
                    case "B":
                        Console.WriteLine("Enter your card number:");
                        var cardNum = BasicCommands.GetText().ToUpper();
                        Console.WriteLine("Enter your PIN:");
                        var pinCode = BasicCommands.GetPin();
                        for (var i = 0; i < users.Count; i++)
                        {
                            
                        }
                        break;
                    case "C":
                        atmStop = true;
                        break;
                }
                
                
            } 
            while (atmStop);
            #endregion
        }
       
            
        
    }
}