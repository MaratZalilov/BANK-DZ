using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_DZ
{
    internal class Human
    {
        private string _name;
        private string _number;
        private int _money;
        private bool _isHave = false;

        public void GetNumber()
        {
            Console.WriteLine($"Ваш номер счёта в банке {_number}");
        }

        public void DeleteNumber(Bank bank1, Human human1)
        {
            if (_isHave == true)
            {
                _isHave = false;
                bank1.CloseScore(human1, bank1);
            }
            else
            {
                Console.WriteLine("Вы не имеете счёт в банке");
            }
        }

        public int GetMoney()
        {
            return _money;
        }

        public int AmountMoney()
        {
            Console.WriteLine("Укажите кол-во ваших средств");
            string select1 = Console.ReadLine();
            int money1 = int.Parse(select1);
            _money = money1;
            return _money;
        }

        public int Deposit()
        {
            _money = _money - 1500;
            _isHave = true;
            Console.WriteLine($"Средств осталось {_money}");
            return _money;
        }

        public int TopUpAccount()
        {
            string select1 = Console.ReadLine();
            int money1 = int.Parse(select1);
            if (_money >= money1)
            {
                _money = _money - money1;
                Console.WriteLine($"Вы пополнили счёт");
                return money1;
            }
            else
            {
                Console.WriteLine($"У вас нет столько средств");
            }
            return 0;
        }

        public int WitchDrawMoney(Bank bank)
        {
            string select1 = Console.ReadLine();
            int money1 = int.Parse(select1);
            if (bank.GetAccountMoney() < money1)
            {
                Console.WriteLine("На вашем счету недостаточно средств");
            }
            else if (bank.GetAccountMoney() >= money1)
            {
                if (bank.GetAccountMoney() != 0)
                {
                    _money = _money + money1;
                    return money1;
                }

            }

            return 0;
        }

        public bool IsHave()
        {
            return _isHave;
        }

        public string SetName()
        {
            if (_isHave == true)
            {
                Console.WriteLine("У вас уже есть счёт в банке");
                return _name;
            }
            else
            {
                Console.WriteLine("Введите ваше имя");
                string money1 = Console.ReadLine();
                _name = money1;
                return _name;
            }
        }

        public string GetName()
        {
            return _name;
        }

        public int TakeMoney(Bank bank1)
        {
            _money = _money + bank1.GetAccountMoney();
            Console.WriteLine();
            Console.WriteLine($"Средства со счёта вернулись, количество ваших средств - {_money}");
            return _money;
        }

    }
}
