using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftwareNEW
{
    public class BankSystem
    {
        private DataBase _dataBase = new DataBase();

        public User GetUser(int userId)
        {
            return _dataBase.GetUserById(userId);
        }

        public BankCard GetCard(string numberCard)
        {
           return _dataBase.GetCardByNumber(numberCard);
        }

        public bool Authenticate(string numberCard, string pinCode)
        {
            BankCard bankCard = _dataBase.GetCardByNumber(numberCard);

            if (bankCard != null)
            {
                if (pinCode == bankCard.PinCode)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsThereBankCard(string numberCard)
        {
            BankCard bankCard = _dataBase.GetCardByNumber(numberCard);
            return bankCard != null;
        }

        public int GetCardId(string numberCard)
        {
            BankCard bankCard = _dataBase.GetCardByNumber(numberCard);
            return bankCard.Id;
        }

        public bool IsUserMoneyEnough(int desiredSum, int userId)
        {
            User user = _dataBase.GetUserById(userId);
            return user.Money >= desiredSum;
        }

        public void Deposit(int desiredSum, int cardId, int userId)
        {
            BankCard bankCard = _dataBase.GetCardById(cardId);
            User user = _dataBase.GetUserById(userId);
        }
    }
}
