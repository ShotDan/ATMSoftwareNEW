using System;
using System.Collections.Generic;
using System.Linq;
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

                string enteredNumberCard = GetUserInput("Введите номер вашей карты:");
                string enteredPinCode = GetUserInput("Введите пин-код вашей карты:");

                if (_bankSystem.Authenticate(enteredNumberCard, enteredPinCode))
                {
                    Console.WriteLine("Вход успешно совершён!");
                    bool isEntered = true;

                    while (isEntered)
                    {
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Выберите операцию:\n1 - Положить наличные\n2 - Снять наличные\n3 - Перевести деньги на другую карту\n4 - Изменить пин-код карты\n5 - Выход");
                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
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

        private string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
