using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_6
{
    //class Bank_account
    //{
        //enum account { incorrect, saving, current };
        //private int number;
        //private account type;
        //private decimal balance;
        //public void Print()
        //{ 
        //    Console.WriteLine($"number: {number}" +
        //                    $"\nbalance: {balance}" +
        //                    $" \ntype: {type}");
                     
        //}
        //public void GetBank_Account()
        //{
        //    Console.WriteLine("Введите номер счета:");
        //    bool result = int.TryParse(Console.ReadLine(), out int temp);
        //    if (result)
        //    {
        //        number = temp;
        //    }
        //    else
        //    { 
        //        Console.WriteLine("Ошибка при вводе номера:"); 
        //    }
        //    Console.WriteLine("Введите баланс:");
        //     result = decimal.TryParse(Console.ReadLine(), out decimal temp1);
        //    if (result)
        //    {
        //        balance = temp1;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ошибка при вводе баланса");
        //    }
        //    Console.WriteLine("Выберите тип счета: saving или current\nВведите 1 или 2");
        //     result = Int32.TryParse(Console.ReadLine(), out temp);
        //    switch (temp)
        //    {
        //        case 1:
        //            type = account.saving;
        //            break;
        //        case 2:
        //            type = account.current;
        //            break;
        //        default:
        //            Console.WriteLine("Нужно вводить только 1 или 2");
        //            break;
        //    }

    //    }
    //}
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про банковский счет");
            Bank_account _account1 = new Bank_account();
            _account1.GetBank_Account();
            _account1.IncreaseNum();
            _account1.Print();
            Bank_account _account2 = new Bank_account();
            _account2.GetBank_Account();
            _account2.IncreaseNum();
            _account2.Print();
            Bank_account _account3 = new Bank_account();
            _account3.GetBank_Account();
            _account3.IncreaseNum();
            _account3.PutItOnTheAccount();
            _account3.WithdrawFromTheAccount();
            _account3.Print();
            Console.WriteLine("Задание про здание");
            Building building = new Building();
            Console.WriteLine("Установить номер дома" +
                "\nУстановить кол-во квартир" +
                "\nУстановить кол-во этажей\n" +
                "Установить кол-во подъездов");
            building.GiveNumber();
        }
    }
}
