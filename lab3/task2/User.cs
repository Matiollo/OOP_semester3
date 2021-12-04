namespace task2
{
    public class User
    {
        public string name; 
        public string surname; 
        public string keyWord; 
        public string login;
        public string hashedPassword;
        public string city;
        public int age;
        public string email;

        public User(string name, string surname, string keyWord, string login, 
            string hashedPassword, string city, int age, string email)
        {
            this.name = name;
            this.surname = surname;
            this.keyWord = keyWord;
            this.login = login;
            this.hashedPassword = hashedPassword;
            this.city = city;
            this.age = age;
            this.email = email;
        }

        public override string ToString()
        {
            return $"{this.name} {this.surname}:\r\n    Login: {this.login}\r\n    City: {this.city}" +
                $"\r\n    Age: {this.age} years old\r\n    Email: {this.email}";
        }
    }
}