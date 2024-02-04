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

        private void InitUsers()
        {
            AddUser("TEST");
            AddUser("Андрей");
        }

        private void InitCards()
        {
            AddCard(1, "1111111111111111", "1111", 19000);
            AddCard(2, "2222222222222222", "1505", 13000);

        }

        private void AddUser(string name)
        {
            User user = new User(nextUserId, name);
            nextUserId++;
            _users.Add(user);
        }

        private void AddCard(int userId, string numCard, string pinCard, int money)
        {
            BankCard bankCard = new BankCard(nextCardId, userId, numCard, pinCard, money);
            nextCardId++;
            _bankCards.Add(bankCard);
        }

        public BankCard GetCardById(int cardId)
        {
            return _bankCards.FirstOrDefault(card => card.Id == cardId);
        }

        public User GetUserById(int userId)
        {
            return _users.FirstOrDefault(user => user.Id == userId);
        }

        public BankCard GetCardByNumber(string cardNumber)
        {
            return _bankCards.FirstOrDefault(card => card.Number == cardNumber);
        }
    }
}
