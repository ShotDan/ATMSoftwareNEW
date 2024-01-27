using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftwareNEW
{
    public class User
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public string Name { get; private set; }
        public int Money { get; private set; }

        public User(int id, int age, string name, int money)
        {
            Id = id;
            Age = age;
            Name = name;
            Money = money;
        }
    }
}
