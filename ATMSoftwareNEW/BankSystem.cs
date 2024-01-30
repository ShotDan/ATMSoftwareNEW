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

        public bool Authenticate(string numberCard, string pinCode)
        {
            BankCard bankCard = _dataBase.GetCard(numberCard);

            if (bankCard != null && bankCard.CheckPinCode(pinCode))
            {
                return true;
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
