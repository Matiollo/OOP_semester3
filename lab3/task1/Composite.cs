using System;
using System.Collections.Generic;

namespace task1
{
    public class Composite: Element
    {
        private int numberOfPatients;
        private Doctor headDoctor;
        public List<Element> elements = new List<Element>();

        public Composite(string name) : base(name)
        {
            this.name = name;
        }

        public Composite(string name, int numberOfPatients, Doctor headDoctor) : base(name)
        {
            this.name = name;
            this.numberOfDoctors = 1;
            this.numberOfPatients = numberOfPatients;
            this.elements.Add(headDoctor);
            this.headDoctor = headDoctor;
        }

        public override void Add(Element element)
        {
            this.elements.Add(element);
            this.numberOfDoctors += element.numberOfDoctors;
        }

        public override void Remove(Element element)
        {
            if(this.elements.Remove(element))
            {
                this.numberOfDoctors -= element.numberOfDoctors;
            }
            else
            {
                Console.WriteLine($"Doctor {element.name} is not a part of {this.name}.");
            }
        }

        public override void DoMedicalCheckUp()
        {
            foreach(Element element in this.elements)
            {
                element.DoMedicalCheckUp();
            }
        }
    }
}