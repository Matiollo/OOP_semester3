using System.Collections.Generic;

namespace task2
{
    public class OldSystem: ISystem
    {                
        private List<User> users = new List<User>();

        public void AddUser(string name, string surname, string keyWord, string login, 
            string hashedPassword, string city, int age, string email)
        {
            this.users.Add(new User(name, surname, keyWord, login, hashedPassword, city, age, email));
        }

        // Methods to work with users

        public void PrintUsers()
        {
            foreach(User user in this.users)
            {
                System.Console.WriteLine(user + "\r\n");
            }
        }
    }
}