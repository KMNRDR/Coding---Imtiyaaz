namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Variables
            int pin, deposit, withdrawal, newPIN;
            double balance, newBalance;
            string transactions, transD, transW, transV, transC;

            //Values
            balance = 5000;
            transD = "Deposit";
            transW = "Withdraw";
            transV = "View Balance";
            transC = "Change PIN";
            
            Console.WriteLine("Please enter PIN number");
            pin = Convert.ToInt32(Console.ReadLine());

            if (pin == 2005)
            {
                Console.WriteLine("Welcome User, please choose one of the following options");
                Console.WriteLine("Deposit");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Withdraw");
                Console.WriteLine("----------------------------");
                Console.WriteLine("View Balance");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Change PIN");
                Console.WriteLine("----------------------------");
                transactions = Console.ReadLine();// Case Sensitive
                Console.ReadKey();
                 
                 if (transactions == transD) 
                 {
                    Console.WriteLine("Deposit has been selected");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Please enter the amount you would like deposit");
                    deposit = Convert.ToInt32(Console.ReadLine());

                    newBalance = balance + deposit;

                    Console.WriteLine("Thank you for your service, your new balance is R" + newBalance);
                    Console.ReadKey();
                 }
                 else if (transactions == transW) 
                 {
                    Console.WriteLine("Withdraw has been selected");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Please enter the amount you would like to withdraw");
                    withdrawal = Convert.ToInt32(Console.ReadLine());

                    newBalance = balance - withdrawal;

                    Console.WriteLine("Thank you for your service, your new balance is R" + newBalance);
                    Console.ReadKey();
                 }
                 else if (transactions == transV) 
                 {
                    Console.WriteLine("View Balance has been selected");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Current Balance : R" + balance);
                    Console.ReadKey();

                 }
                 else if (transactions == transC) 
                 {
                    Console.WriteLine("Change PIN has been selected");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Please enter new PIN");
                    newPIN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Thank you for your service, your new PIN is " + newPIN);
                    Console.ReadKey();
                 }
            }
            else
            {
                Console.WriteLine("Incorrect PIN");
            }
        }
    }
}

