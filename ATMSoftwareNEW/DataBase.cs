using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftwareNEW
{
    public class DataBase
    {
        private int nextUserId = 1;
        private int nextCardId = 1;
        private List<User> _users = new List<User>();
        private List<BankCard> _bankCards = new List<BankCard>();

        public DataBase()
        { 
            InitUsers();
            InitCards();
        }

        public BankCard GetCard(string enteredNumberCard)
        {
            foreach (BankCard bankCard in _bankCards)
            {
                if(bankCard.Number == enteredNumberCard)
                {
                    return bankCard;
                }
            }

            return null;
        }

        private void InitUsers()
        {
            AddUser(11, "TEST", 9000);
            AddUser(30, "Андрей", 11000);
        }

        private void InitCards()
        {
            AddCard(1,"1111 1111 1111 1111", "1111", 19000);
            AddCard(2,"1111 1111 1111 1111", "1111", 19000);

        }

        private void AddUser(int age, string name, int money)
        {
            User user = new User(nextUserId,age, name, money);
            nextUserId++;
            _users.Add(user);
        }

        private void AddCard(int userId, string numCard, string pinCard, int money)
        {
            BankCard bankCard = new BankCard(nextCardId, userId, numCard, pinCard, money);
            nextCardId++;
            _bankCards.Add(bankCard);
        }
    }
}
