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

        public void Deposit(int desiredSum, int cardId)
        {
            BankCard bankCard = _dataBase.GetCardById(cardId);
        }
    }
}
