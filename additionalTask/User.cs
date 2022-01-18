using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask
{
    internal class User
    {
        private string _login, _lName, _fName;
        private byte _yearsOld;
        private readonly DateTime _dateCreation;

        public string Login { get => _login; set => _login = value; }
        public string LName { get => _lName; set => _lName = value; }
        public string FName { get => _fName; set => _fName = value; }
        public byte YearsOld { get => _yearsOld; set => _yearsOld = value; }

        public DateTime DateCreation => _dateCreation;

        public User() => _dateCreation = DateTime.Now;
        public User(string login, string lName, string fName, byte yearsOld)
        {
            this.Login = login;
            this.LName = lName;
            this.FName = fName;
            this.YearsOld = yearsOld;
            _dateCreation = DateTime.Now;
        }
        public void Show()
        {
            Console.WriteLine("user login: " + _login);
            Console.WriteLine("user name: " + _fName);
            Console.WriteLine("user last name: " + _lName);
            Console.WriteLine("user years old: " + _yearsOld);
            Console.WriteLine("account creation date: " + DateCreation);
        }
    }
}
