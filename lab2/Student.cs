using System;

namespace lab2
{
    public class Student : BJJPracticioner, IBeginner, IMember
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
        }
        
        public Student(string name, string surname, Professor professor, int payment)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.professor = professor;
            this.payment = payment;
        }

        public Student(string name, string surname, Professor professor, int payment, int yearsPracticed, int yearsSpentOnRelatedMartialArts = 0)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = yearsPracticed;
            this.yearsSpentOnRelatedMartialArts = yearsSpentOnRelatedMartialArts;
            this.professor = professor;
            this.payment = payment;
        }

        private Student(string name, string surname, Professor professor)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.professor = professor;
            this.payment = 0;
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
            Func<int, int> countFunc = Count;
            int hours = this.GetHours(this.payment, countFunc);
            return hours;
        }

        protected void CheckEnthusiasm(int hoursTraining)
        {
            if(hoursTraining == 0)
            {
                throw new EnthusiasmException("Lacks enthusiasm, visits no trainings.", new EnthusiasmExceptionArgs(this.name, this.surname));
            }
        }

        private int GetHours(int payment, Func<int, int> retF)
        {
            return retF(payment);
        }

        private int Count(int x)
        {
            return (int)Math.Floor(x / 100.0);
        }

        public Student GetIdenticalStudentWithMemoryLoss()
        {
            return new Student(this.name, this.surname, this.professor);
        }

        public void DoubtYourself()
        {
            Console.WriteLine("Doubts himself/herself sometimes.");
        }

        void IBeginner.CommunicateWithOtherMembers()
        {
            Console.WriteLine("Communicates with other members to learn from their experience.");
        }

        void IMember.CommunicateWithOtherMembers()
        {
            Console.WriteLine("Communicates with other members for fun.");
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