using System;

namespace task1
{
    class Program
    {
        static void Main()
        {
            Composite hospital = new Composite("Abraham", 10, new Doctor("Alice"));

            Composite department1 = new Composite("Dentists", 5, new Doctor("Michael"));
            department1.Add(new Doctor("Daniel"));
            department1.Add(new Doctor("Kyle"));
            department1.Add(new Doctor("Synthia"));

            hospital.Add(department1);
            hospital.Add(new Doctor("Abraam"));

            hospital.DoMedicalCheckUp();
        }
    }
}
