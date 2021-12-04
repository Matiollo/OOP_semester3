namespace task2
{
    public interface ISystem
    {
        public void AddUser(string name, string surname, string keyWord, string login, 
            string hashedPassword,string city, int age, string email);
    }
}