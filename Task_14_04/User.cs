using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    internal class User
    {
        private static User currentUser;
        public static User CurrentUser
        {
            get { return currentUser; }
        }
        public static void SetCurrentUser(User user)
        {
            currentUser = user;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public User(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}