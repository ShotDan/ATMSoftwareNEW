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

        public User GetUser(int userId)
        {
            return _users.FirstOrDefault(user => user.Id == userId);
        }

        public BankCard GetCard(string cardNumber)
        {
            return _bankCards.FirstOrDefault(card=> card.Number == cardNumber);
        }

        private void InitUsers()
        {
            AddUser(11, "TEST", 9000);
            AddUser(30, "Андрей", 11000);
        }

        private void InitCards()
        {
            AddCard(1,"1111 1111 1111 1111", "1111", 19000);
            AddCard(2,"2222 2222 2222 2222", "1505", 13000);

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
