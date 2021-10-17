using System;

namespace lab1
{
    public class Student : BJJPracticioner
    {
        public Professor professor;
        protected int payment;

        public int Payment
        {
            get
            {
                return this.payment;
            }
            set
            {
                if(value >= 0)
                {
                    this.payment = value;
                }
            }
        }

        public Student()
        {
            this.name = "John";
            this.surname = "Dow";
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.professor = null;
            this.payment = 0;
            Console.WriteLine("[Student constructor]");
        }
        
        public Student(string name, string surname, Professor professor, int payment)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.professor = professor;
            this.payment = payment;
            Console.WriteLine("[Student constructor]");
        }

        public Student(string name, string surname, Professor professor, int payment, int yearsPracticed, int yearsSpentOnRelatedMartialArts = 0)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = yearsPracticed;
            this.yearsSpentOnRelatedMartialArts = yearsSpentOnRelatedMartialArts;
            this.professor = professor;
            this.payment = payment;
            Console.WriteLine("[Student constructor]");
        }

        private Student(string name, string surname, Professor professor)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.professor = professor;
            this.payment = 0;
            Console.WriteLine("[Student constructor]");
        }

        public void PayForClasses()
        {
            Console.WriteLine($"Pays {this.payment} grn a month.");
        }

        public virtual void WatchEducationalVideos()
        {
            Console.WriteLine("Watches 3 hours of educational videos a week.");
        }

        protected int CountTrainingHoursBasedOnPayment()
        {
            int hours = (int)Math.Floor(this.payment / 100.0);
            return hours;
        }

        public Student GetIdenticalStudentWithMemoryLoss()
        {
            return new Student(this.name, this.surname, this.professor);
        }

        protected override void CleanUp(bool diposing)
        {
            if(!this.disposed)
            {
                // add logic specific to the current class
                if(diposing)
                {
                    // clean managed resourses
                    this.name = null;
                    this.surname = null;
                    this.yearsPracticed = 0;
                    this.yearsSpentOnRelatedMartialArts = 0;
                    this.professor = null;
                    this.payment = 0;
                }
                // if there were any unmanaged resourses, they would be cleaned up here
                this.disposed = true;
            }
        }
    }
}