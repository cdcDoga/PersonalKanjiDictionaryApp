using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiDictionaryApp
{
    public class User
    {
        public string mail;
        public string password;
        public List<Kanji> kanji_list;

        public User(string mail, string password)
        {
            this.mail = mail;
            this.password = password;
            kanji_list = new List<Kanji>();
        }

        public bool UserMatches(User potantial_user)
        {
            if (potantial_user.GetMail() != mail) return false;
            if (potantial_user.GetPassword() != password) return false;

            return true;
        }

        public bool WrongPassword(User potantial_user)
        {
            if (potantial_user.GetMail() != mail) return false;
            if (potantial_user.GetPassword() == password) return false;

            return true;
        }

        public void SetMail(string mail) { this.mail = mail; }
        public string GetMail() { return mail; }

        public void SetPassword(string password) { this.password = password; }
        public string GetPassword() { return password; }

        public void InitiateDictionary() { kanji_list = new List<Kanji>(); }
        public void SetDictionary(List<Kanji> kanji_dictionary) { this.kanji_list = kanji_dictionary; }
        public List<Kanji> GetDictionary() { return kanji_list; }

        public List<Kanji> FilterKanji(string attribute)
        {
            List<Kanji> filtered_kanji_list = new List<Kanji>();

            foreach (var item in kanji_list)
            {
                if (item.matches(attribute)) { filtered_kanji_list.Add(item); }
            }

            return filtered_kanji_list;
        }

        public bool CheckExistence(Kanji kanji)
        {
            foreach (var item in kanji_list)
            {
                if(item.GetCharacter() == kanji.GetCharacter()) { return true; }
            }

            return false;
        }

        public void AddKanji(Kanji kanji)
        {
            if (!CheckExistence(kanji)) { kanji_list.Add(kanji); }
        }

        public void DeleteKanji(Kanji kanji)
        {
            if (CheckExistence(kanji)) { kanji_list.Remove(kanji); }
        }

        public Kanji FindKanji(string character)
        {
            foreach (var item in kanji_list)
            {
                if (item.GetCharacter() == character) { return item; }
            }

            return null;
        }
    }
}
