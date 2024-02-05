using lab5.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main()
        {

            Zad1();
            Zad2();
        }
        static void Zad1()
        {
            Circle circle = new Circle(5);

            Console.WriteLine($"Area of the circle: {circle.CalculateArea()}");


            Square square = new Square(4);

            Console.WriteLine($"Area of the square: {square.CalculateArea()}");
        }
        static void Zad2()
        {
            Account account = new Account();

            
            account.AddTransaction(new IncomeTransaction(1000M, DateTime.Now));
            account.AddTransaction(new ExpenseTransaction(500M, DateTime.Now));
            account.AddTransaction(new IncomeTransaction(200M, DateTime.Now));
            account.AddTransaction(new ExpenseTransaction(100M, DateTime.Now));

            Console.WriteLine($"Total Income: {Account.TotalIncome}");
            Console.WriteLine($"Total Expenses: {Account.TotalExpenses}");
        }
    }
}
