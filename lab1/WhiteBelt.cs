using System;

namespace lab1
{
    public class WhiteBelt : Student
    {
        public WhiteBelt()
        {
            this.name = "John";
            this.surname = "Dow";
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.professor = null;
            this.payment = 0;
            Console.WriteLine("[WhiteBelt constructor]");
        }

        public WhiteBelt(string name, string surname, Professor professor, int payment, int yearsSpentOnRelatedMartialArts = 0)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = yearsSpentOnRelatedMartialArts;
            this.professor = professor;
            this.payment = payment;
            Console.WriteLine("[WhiteBelt constructor]");
        }

        public override void WatchEducationalVideos()
        {
            base.WatchEducationalVideos();
            Console.WriteLine("Rewatches videos for another 2 hours.");
        }

        public override void Train()
        {
            int hours = this.CountTrainingHoursBasedOnPayment();
            Console.WriteLine($"Trains for {hours} hours a week.");
        }

        public void DoSimpleLeglocks()
        {
            Console.WriteLine("Does simple leglocks.");
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
                }
                // if there were any unmanaged resourses, they would be cleaned up here
                this.disposed = true;
            }
        }
    }
}