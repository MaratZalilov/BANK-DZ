
using BANK_DZ;
using System;

Human human1 = new Human();
Bank bank1 = new Bank();
while (true)
{
    Menu();
}
void Menu()
{
    Console.WriteLine($"Меню банка {bank1.SetNameBank()}");
    Console.WriteLine("1. Открыть Счёт");
    Console.WriteLine("2. Пополнить счёт");
    Console.WriteLine("3. Посмотреть информацию по счёту");
    Console.WriteLine("4. Закрыть счёт");
    Console.WriteLine("5. Снять деньги");
    Console.WriteLine("6. Расчитать сумму, которая будет на счету через год");
    string select1 = Console.ReadLine();
    int money1 = int.Parse(select1);
    switch (money1)
    {
        case 1:
            human1.SetName();
            Console.WriteLine("Начальный взнос для открытия счёта 2000");
            bank1.OpenScore(human1);
            break;

        case 2:
            bank1.TopUpAccount(human1);
            break;

        case 3:
            bank1.ScoreInfo(human1);
            break;

        case 4:
            human1.DeleteNumber(bank1, human1);
            break;

        case 5:
            bank1.WithdrawMoney(human1, bank1);
            break;

        case 6:
            bank1.AmmountPerYear(human1);
            break;

            default:
            Console.WriteLine("Ошибка, такого пункта нет");
            break;
    }
}