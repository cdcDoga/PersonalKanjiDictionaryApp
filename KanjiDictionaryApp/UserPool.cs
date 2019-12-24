using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiDictionaryApp
{
    public class UserPool 
    {
        public List<User> users_list;
        public string path;

        public UserPool()
        {
            users_list = new List<User>();
            path = @"DB.json";
        }

        public bool CheckUserExistence(User potential_user)
        {
            foreach (var item in users_list)
            {
                if (item.UserMatches(potential_user)) { return true; }
            }

            return false;
        }

        public bool CheckUsedMail(User potential_user)
        {
            foreach (var item in users_list)
            {
                if (item.WrongPassword(potential_user)) { return true; }
            }

            return false;
        }

        public void AddUser(User user)
        {
            if (!CheckUserExistence(user)) { users_list.Add(user); }
        }

        public void RemoveUser(User user)
        {
            if (CheckUserExistence(user)) { users_list.Remove(user); }
        }
        
        public void UpdateUser(User user)
        {
            if (CheckUserExistence(user))
            { users_list[users_list.IndexOf(FindUser(user.GetMail()))] = user; }
        }

        public User FindUser(string mail)
        {
            foreach (var item in users_list)
            {
                if (item.GetMail() == mail) { return item; }
            }

            return null;
        }
    }
}
