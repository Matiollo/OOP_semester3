using System;

namespace lab2
{
    public class Professor : BJJPracticioner
    {
        public delegate void InformationHandler(string message);
        public event InformationHandler Notify; 

        private int yearsTeaching;
        public bool enthusiasticAboutBJJ = true;
        
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
        }

        public Professor(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.yearsTeaching = 0;
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
        }

        public void Teach()
        {
            try
            {
                CheckEnthusiasm(this.enthusiasticAboutBJJ);
                int hours = this.GetDailyHoursOfTeaching();
                Console.WriteLine($"Teaches {hours} hours a day.");
            }
            catch(EnthusiasmException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                Console.WriteLine($"Professor {e.args.name} {e.args.surname} is sent om motivational weekend.");
            }
        }

        private void CheckEnthusiasm(bool enthusiastic)
        {
            if(!enthusiastic)
            {
                throw new EnthusiasmException("Cannot teach classes without love for the martial art.", 
                    new EnthusiasmExceptionArgs(this.name, this.surname));
            }
        }

        public void StartTraining()    
        {
            Console.WriteLine("Starts training.");
            Notify?.Invoke("Training has been started.");
        }

        public void RaisePayment()    
        {
            Console.WriteLine("Raises payment.");
            Notify?.Invoke("Payment has been raised.");
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