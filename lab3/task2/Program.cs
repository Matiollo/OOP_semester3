using System;

namespace task2
{
    class Program
    {
        static void Main()
        {
            OldSystem oldSystem = new OldSystem();
            NewSystem newSystem = new NewSystem(oldSystem);

            newSystem.AddUser("Margo", "Goody", "key", "qwerty", "ew34hfj5545k45t4o34");

            oldSystem.PrintUsers();
        }
    }
}
