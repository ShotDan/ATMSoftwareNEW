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
    }
}
