using System;

namespace task1
{
    public class Doctor: Element
    {
        public Doctor(string name) : base(name)
        {
            this.name = name;
            this.numberOfDoctors = 1;
        }

        public override void Add(Element element)
        {
            Console.WriteLine("Impossible operation.");
        }

        public override void DoMedicalCheckUp()
        {
            Console.WriteLine($"Doctor {this.name} visited.");
        }

        public override void Remove(Element element)
        {
            Console.WriteLine("Impossible operation.");
        }
    }
}