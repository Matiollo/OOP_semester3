using System;
using System.Collections.Generic;

namespace lab2
{
    class Program
    {
        static void Main()
        {
            Professor professor = new Professor();
            
            professor.Notify += delegate(string mes)
            {
                Console.WriteLine("\r\n***\r\nNotification!\r\n" + mes + "\r\n***\r\n");
            };

            List<string> notifications = new List<string>();
            professor.Notify += mes => notifications.Add(mes);

            professor.StartTraining();
            professor.RaisePayment();

            Student student1 = new WhiteBelt("Annabel", "Smith", professor, 1200);
            student1.Train();

            Student student2 = new BlueBelt();

            Action<Student, Professor> action = ChangeProf;
            ChangeRelationship(student2, professor, action);

            Console.WriteLine();
            
            professor.enthusiasticAboutBJJ = false;
            professor.Teach();

            Console.WriteLine();
            student2.Train();

            Console.WriteLine();
            student1.BeAGoodStudent();

            student1.Dispose();
            student2.Dispose();
            professor.Dispose();
        }

        static void ChangeRelationship(Student student, Professor professor, Action<Student, Professor> action)
        {
            action(student, professor);
        }

        static void ChangeProf(Student student, Professor professor)
        {
            student.professor = professor;
        }
    }
}
