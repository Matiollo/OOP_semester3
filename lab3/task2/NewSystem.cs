namespace task2
{
    public class NewSystem: ISystem
    {
        private OldSystem oldSystem;

        public NewSystem(OldSystem oldSystem)
        {
            this.oldSystem = oldSystem;
        }
        
        public void AddUser(string name, string surname, string keyWord, string login, 
            string hashedPassword, string city = "-", int age = 18, string email = "system@gmail.com")
        {
            this.oldSystem.AddUser(name, surname, keyWord, login, hashedPassword, city, age, email);
        }
    }
}