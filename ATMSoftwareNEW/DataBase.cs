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
            AddUser(11, "TEST");
            AddUser(30, "Андрей");
        }

        private void InitCards()
        {
            AddCard(1,"1111 1111 1111 1111", "1111");
            AddCard(3,"1111 1111 1111 1111", "1111");

        }

        private void AddUser(int age, string name)
        {
            User user = new User(nextUserId,age, name);
            nextUserId++;
            _users.Add(user);
        }

        private void AddCard(int userId, string numCard, string pinCard)
        {
            BankCard bankCard = new BankCard(nextCardId, userId, numCard, pinCard);
            nextCardId++;
            _bankCards.Add(bankCard);
        }

        public void ShowAll()
        {
            Console.WriteLine("Пользователи");

            foreach (var user in _users)
            {
                Console.WriteLine($"{user.Id}, {user.Name}, {user.Age}");
            }

            Console.WriteLine("Карты:");

            foreach (var card in _bankCards)
            {
                Console.WriteLine($"{card.Id}, {card.UserId}, {card.Number}, {card.PinCode}");
            }
        }
    }
}
