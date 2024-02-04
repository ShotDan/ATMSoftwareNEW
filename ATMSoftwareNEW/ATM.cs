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
        private bool _auth;
        private int _bankCardId;
        private int _userId;

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
                    BankCard bankCard = _bankSystem.GetCard(cardNumber);
                    User user = _bankSystem.GetUser(bankCard.UserId);
                    _bankCardId = bankCard.Id;
                    _userId = user.Id;

                    if (bankCard != null && pinCode == bankCard.PinCode)
                    {
                        Console.WriteLine("Вход успешно совершён!");
                        _auth = true;
                    }
                    else
                    {
                        Console.WriteLine("Неправильный номер карты или пин-код!");
                    }

                    while (_auth)
                    {
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine($"{user.Name}, добро пожаловать!\nНа вашем счёте: {bankCard.Money}");

                        Console.WriteLine();
                        Console.WriteLine("Выберите операцию:\n1 - Пополнить счёт\n2 - Снять наличные\n3 - Перевести деньги на другую карту\n4 - Изменить пин-код карты\n5 - Выход");
                        string userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                TryDeposit();
                                break;

                            case "2":
                                break;

                            case "3":
                                break;

                            case "4":
                                break;

                            case "5":
                                _auth = false;
                                break;

                            default:
                                Console.WriteLine("Некорректный ввод!");
                                break;
                        }
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

        private bool ValidateCardNumber(string cardNumber)
        {
            return cardNumber.Length == 16 && long.TryParse(cardNumber, out long _);
        }

        private bool ValidatePinCode(string pinCode)
        {
            return pinCode.Length == 4 && int.TryParse(pinCode, out int _);
        }

        private int ValidateDesiredSum(string userInput)
        {
            int.TryParse(userInput, out int desiredSum);
            return desiredSum;
        }

        private void TryDeposit()
        {
            Console.WriteLine("Введите сумму, которую вы хотите положить:");
            string userInput = Console.ReadLine();
            int desiredSum = ValidateDesiredSum(userInput);

            if (desiredSum > 0)
            {

                _bankSystem.Deposit(desiredSum, _bankCardId);
            }
            else
            {
                Console.WriteLine("Неккоректное число!");
            }
        }
    }
}
