using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftwareNEW
{
    public class ATM
    {
        private BankSystem _bankSystem = new BankSystem();

        public void Work()
        {
            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine("Добро пожаловать в систему банкомата «HAVBANK»");

                Console.WriteLine("Введите номер вашей карты:");
                string cardNumber = Console.ReadLine();

                Console.WriteLine("Введите пин-код вашей карты:");
                string enteredPinCode = Console.ReadLine();

                if (_bankSystem.Authenticate(cardNumber, enteredPinCode))
                {
                    Console.WriteLine("Вход успешно совершён!");
                    bool isEntered = true;

                    while (isEntered)
                    {
                        Console.ReadKey();
                        Console.Clear();

                        _bankSystem.ShowCardInfo(cardNumber);

                        Console.WriteLine();
                        Console.WriteLine("Выберите операцию:\n1 - Пополнить счёт\n2 - Снять наличные\n3 - Перевести деньги на другую карту\n4 - Изменить пин-код карты\n5 - Выход");
                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("Введите сумму, которую вы хотите положить:");
                                userInput = Console.ReadLine();
                                _bankSystem.PutMoney(userInput);
                                break;

                            case "2":
                                break;

                            case "3":
                                break;

                            case "4":
                                break;

                            case "5":
                                isEntered = false;
                                break;

                            default:
                                Console.WriteLine("Некорректный ввод!");
                                break;
                        }
                    }
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
