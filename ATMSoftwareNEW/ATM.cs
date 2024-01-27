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
                    Console.WriteLine("Успешно!");
                }
                else
                {
                    Console.WriteLine("Нет");
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
