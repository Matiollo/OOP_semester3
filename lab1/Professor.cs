using System;

namespace lab1
{
    public class Professor : BJJPracticioner
    {
        private int yearsTeaching;
        
        public int YearsTeaching
        {
            get
            {
                return this.yearsTeaching;
            }
            set
            {
                if(value >= this.yearsPracticed && value >= this.YearsTeaching)
                {
                    this.yearsTeaching = value;
                }
            }
        }

        public Professor()
        {
            this.name = "John";
            this.surname = "Dow";
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.yearsTeaching = 0;
            Console.WriteLine("[Professor constructor]");
        }

        public Professor(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.yearsTeaching = 0;
            Console.WriteLine("[Professor constructor]");
        }

        public Professor(string name, string surname, int yearsPracticed, int yearsTeaching, int yearsSpentOnRelatedMartialArts = 0)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = yearsPracticed;
            this.yearsSpentOnRelatedMartialArts = yearsSpentOnRelatedMartialArts;
            if(yearsPracticed < YearsTeaching)
            {
                this.yearsTeaching = yearsPracticed;
            }
            else
            {
                this.yearsTeaching = yearsTeaching;
            }
            Console.WriteLine("[Professor constructor]");
        }

        public void Teach()
        {
            int hours = this.GetDailyHoursOfTeaching();
            Console.WriteLine($"Teaches {hours} hours a day.");
        }

        private int GetDailyHoursOfTeaching()
        {
            if(this.yearsTeaching <= 2)
            {
                return 6;
            }
            return 12;
        }

        public override void Train()
        {
            Console.WriteLine("Trains for 12 hours a week.");
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
                    this.yearsTeaching = 0;
                }
                // if there were any unmanaged resourses, they would be cleaned up here
                this.disposed = true;
            }
        }
    }
}