using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT
{
    class User
    {
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
        public string Login { get => login; set => login = value; }
        public string Hashpass { get => password; }

        public User(int id, string role, string name,  string login, string password)
        {
            this.password = password;
            this.login = login;
            this.id = id;
            this.name = name;
            this.role = role;
        }

        private int id;
        private string role;
        private string name;
        private string password;
        private string login;
    }
}
