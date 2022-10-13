using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_DZ
{
    internal class Bank
    {
        private string _name;
        private int _accountMoney;
        private int _min;
        private int _interestOnDeposit;
        public Bank()
        {
            _interestOnDeposit = 3;
            _min = 1500;
        }

        public bool OpenScore(Human human1)
        {
            if (human1.IsHave() == true)
            {
                Console.WriteLine("У вас уже есть счёт");
            }
            else if (human1.IsHave() == false)
            {
                if (human1.AmountMoney() < 2000)
                {
                    Console.WriteLine("Нехватает денег для открытия счёта");
                    return false;
                }
                else
                {
                    Console.WriteLine("Начальный взнос для открытия счёта 2000, вы уверены что хотите открыть счёт?");
                    Console.WriteLine("1. Да");
                    Console.WriteLine("2. Нет");
                    string select1 = Console.ReadLine();
                    int money1 = int.Parse(select1);
                    if (money1 == 1)
                    {
                        human1.Deposit();
                        GetNumber(human1);
                        _accountMoney = _accountMoney + 2000;
                    }
                    else if (money1 == 2)
                    {

                        return human1.IsHave();
                    }
                }
            }
            return false;
        }

        public void TopUpAccount(Human human1)
        {
            if (human1.IsHave() == true)
            {
                Console.WriteLine("Введите количество денег, которые вы хотите положить на этот счёт");
                _accountMoney = _accountMoney + human1.TopUpAccount();
                Console.WriteLine($"На вашем счету - {_accountMoney}");
            }
            else
            {
                Console.WriteLine("У вас нет счёта в банке");
            }
        }

        public void ScoreInfo(Human human1)
        {
            if (human1.IsHave() == true)
            {
                Console.WriteLine($"Имя владельца счёта - {human1.GetName()}");
                Console.WriteLine($"Номер вашего счёта - {SetNumberScore()}");
                Console.WriteLine($"Денег на счету - {_accountMoney}");
                Console.WriteLine($"Процент по вкладу - 3%");
            }
            else
            {
                Console.WriteLine("У вас нет счёта в банке");
            }
        }

        public void CloseScore(Human human1, Bank bank1)
        {
            if (human1.IsHave() == false)
            {
                if (_accountMoney == 0)
                {
                    Console.WriteLine("Счёт закрыт");
                }
                else
                {
                    human1.TakeMoney(bank1);
                    _accountMoney = 0;
                }
            }
            else
            {
                Console.WriteLine("У вас нет счёта в банке");
            }
        }

        public void WithdrawMoney(Human human1, Bank bank1)
        {
            if (human1.IsHave() == true)
            {
                Console.WriteLine("Введите количество денег, которые вы хотите снять с этого счёта");

                _accountMoney = _accountMoney - human1.WitchDrawMoney(bank1);
                Console.WriteLine($"На вашем счету - {_accountMoney}");
            }
            else
            {
                Console.WriteLine("У вас нет счёта в банке");
            }
        }

        public void AmmountPerYear(Human humam1)
        {
            if (humam1.IsHave() == true)
            {
                int month = _accountMoney * _interestOnDeposit / 100;
                int year = _accountMoney + month * 12;
                Console.WriteLine($"через год ваш счёт будет составлять - {year}");
            }
            else
            {
                Console.WriteLine("У вас нет счёта в банке");
            }
        }

        public string SetNumberScore()
        {

            string score = "34216568256";
            return score;
        }

        public void GetNumber(Human human1)
        {
            Console.WriteLine($"Номер вашего счёта - {SetNumberScore()}");
            Console.WriteLine($"Имя владельца счёта - {human1.GetName()}");
            Console.WriteLine();
        }

        public int GetAccountMoney()
        {
            return _accountMoney;
        }

        public string SetNameBank()
        {
            _name = "SBERBANK";
            return _name;
        }
    }
}
