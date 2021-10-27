namespace lab2
{
    public static class StudentExtension
    {
        public static void BeAGoodStudent(this Student student)
        {
            System.Console.WriteLine($"Student {student.name} {student.surname} is a good student.");
        }
    }
}