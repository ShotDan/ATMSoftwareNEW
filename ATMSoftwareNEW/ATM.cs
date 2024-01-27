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

                Console.ReadKey();
                Console.Clear();
            }
        }

        private bool AuthenticateUser(string enteredNumberCard, string enteredPinCode)
        {
            
            //enteredNumberCard = enteredNumberCard.Replace(" ", "");

            //if(enteredNumberCard.Length == 16)
            //{
            //   enteredNumberCard = enteredNumberCard.Insert(4, " ").Insert(9, " ").Insert(14, " ");
            //}

            return true; //_dataBase.IsCardAndPinValid(enteredNumberCard, enteredPinCode);
        }

        private string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
