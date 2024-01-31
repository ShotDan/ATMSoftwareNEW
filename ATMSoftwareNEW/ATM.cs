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
                string cardNumber = Console.ReadLine().Replace(" ", "");

                Console.WriteLine("Введите пин-код вашей карты:");
                string pinCode = Console.ReadLine().Replace(" ", "");

                if (ValidateCardNumber(cardNumber) && ValidatePinCode(pinCode))
                {
                    if (_bankSystem.Authenticate(cardNumber, pinCode))
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
                    else
                    {
                        Console.WriteLine("Неправильный номер карты или пин-код!");
                    }
                }
                else
                {
                    Console.WriteLine("Неккоректный номер карты или пин-код!");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        public bool ValidateCardNumber(string cardNumber)
        {
            if (cardNumber.Length == 16 && long.TryParse(cardNumber, out long number))
            {
                return true;
            }

            return false;
        }

        public bool ValidatePinCode(string pinCode )
        {
            if (pinCode.Length == 4 && int.TryParse(pinCode, out int pin))
            {
                return true;
            }

            return false;
        }
    }
}
