using System;

namespace task3
{
    public class Student
    {
        public int id;
        public string name;
        public string surname;
        public DateTime dateOfBirth;
        public double averageScore;

        public Student(int id, string name, string surname, DateTime dateOfBirth, double averageScore)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.averageScore = averageScore;
        }

        public override string ToString()
        {
            return $"[{this.id}] {this.name} {this.surname} -- birthdate: {this.dateOfBirth.ToString("MM/dd/yyyy")}, average score: {this.averageScore};";
        }
    }
}