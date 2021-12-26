using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsGroup kp02 = new StudentsGroup("KP-02", "Faculty of Applied Mathematics");
            kp02.Add(new Student(1, "Ana", "Davidson", new DateTime(2000,12,1), 95));
            kp02.Add(new Student(2, "Mary", "Smith", new DateTime(2000,12,20), 90));
            kp02.Add(new Student(3, "John", "Kane", new DateTime(2001,12,1), 92));
            kp02.Add(new Student(4, "Mary", "Jane", new DateTime(2000,9,2), 87));
            kp02.Add(new Student(5, "David", "Smith", new DateTime(2001,12,19), 95));
            kp02.Add(new Student(6, "June", "Akana", new DateTime(2000,12,2), 90));
            System.Console.WriteLine("Original group:");
            kp02.Print();

            // Get clone of group "KP-02" for policlinic, dean office or student council
            StudentsGroup kp02Clone = kp02.Clone();

            // Checking the clone
            System.Console.WriteLine("\r\nClone group:");
            kp02Clone.Print();
        }
    }
}
