using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftwareNEW
{
    public class BankSystem
    {
        DataBase _dataBase = new DataBase();

        public bool Authenticate(string enteredNumberCard, string enteredPinCode)
        {
            enteredNumberCard = enteredNumberCard.Replace(" ", "");

            if (enteredNumberCard.Length == 16)
            {
                enteredNumberCard = enteredNumberCard.Insert(4, " ").Insert(9, " ").Insert(14, " ");
                BankCard bankCard = _dataBase.GetCard(enteredNumberCard);

                if (bankCard != null && bankCard.CheckPinCode(enteredPinCode))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Неправильный номер карты или пин-код!");
                }

            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }

            return false;
        }

        public void ShowCardInfo(string cardNumber)
        {
            BankCard bankCard = _dataBase.GetCard(cardNumber);
            User user = _dataBase.GetUser(bankCard.UserId);

            if (bankCard != null && user != null)
            {
                Console.WriteLine($"{user.Name}, добро пожаловать!\nНа вашем счёте {bankCard.Money}, Ваши наличные:{user.Money}");
            }
            else
            {
                Console.WriteLine("Ошибка! карты или пользователя не существует");
            }
        }

        public void PutMoney(string userInput)
        {
            if (int.TryParse(userInput, out int value))
            {

            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }
        }
    }
}
