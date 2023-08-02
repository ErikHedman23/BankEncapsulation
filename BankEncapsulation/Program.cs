namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var newUser = new BankAccount();
            Console.WriteLine("Please enter your name here:");
            newUser.Name = Console.ReadLine();
            var myAccountBalance = newUser.GetBalance();
            while (true)
            {
                Console.WriteLine("What would you like to do today: 1. Balance Look Up 2. Deposit 3. Withdraw 4. Exit Account");
                int userSelection;
                if (!int.TryParse(Console.ReadLine(), out userSelection))

                {
                    Console.WriteLine("Invalid entry.\nLet's try this again...");
                    continue;
                }

                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine($"Welcome, {newUser.Name} your current account balance is sitting at: {myAccountBalance}");
                        break;
                    case 2:
                        Console.WriteLine($"Please, {newUser.Name}, enter your amount you would like deposited:");
                        double deposit;
                        if (!double.TryParse(Console.ReadLine(), out deposit))
                        {
                            Console.WriteLine("Invalid entry.");
                            continue;
                        }
                        newUser.Deposit(deposit);
                        myAccountBalance = newUser.GetBalance();
                        Console.WriteLine($"Your current account balance is sitting at: {myAccountBalance}");
                        break;
                    case 3:
                        Console.WriteLine($"How Much would you like to withdraw from your account, {newUser.Name}:");
                        double myWithdrawal;
                        if (!double.TryParse(Console.ReadLine(), out myWithdrawal))
                        {
                            Console.WriteLine("Invalid entry.");
                            continue;
                        }
                        newUser.Withdrawal(myWithdrawal);
                        myAccountBalance = newUser.GetBalance();
                        Console.WriteLine($"Your new account balance is sitting at:{myAccountBalance}");
                        break;
                    case 4:
                        Console.WriteLine("Thank you for banking with us!");
                        return;
                    default:
                        Console.WriteLine("Invalid entry.");
                        break;

                }
            }
        }
    }
}
