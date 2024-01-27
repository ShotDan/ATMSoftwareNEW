using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftwareNEW
{
    public class BankCard
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string Number { get; private set; }
        public string PinCode { get; private set; }
        public int Money { get; private set; }

        public BankCard(int id, int userId, string numCard, string pinCard, int money)
        {
            Id = id;
            UserId = userId;
            Number = numCard;
            PinCode = pinCard;
            Money = money;
        }
    }
}
