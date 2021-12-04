namespace task1
{
    public abstract class Element
    {
        public string name;
        public int numberOfDoctors;

        public Element(string name)
        {
            this.name = name;
        }

        public abstract void Add(Element element);
        public abstract void Remove(Element element);
        public abstract void DoMedicalCheckUp();
    }
}