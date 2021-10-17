using System;

namespace lab1
{
    public class BrownBelt : Student
    {
        private double competitionsScore;
        private bool examinatorDegree;

        public double CompetitionsScore
        {
            get
            {
                return this.competitionsScore;
            }
            set
            {
                if((this.competitionsScore != 0 && this.competitionsScore != 1 && value > 0 && value < 1) 
                    || (this.competitionsScore == 0 && value >= 0 && value < 1) 
                    || (this.competitionsScore == 1 && value > 0 && value <= 1))
                {
                    this.competitionsScore = value;
                }
            }
        }

        public bool ExaminatorDegree
        {
            get
            {
                return this.examinatorDegree;
            }
            set
            {
                if(!this.examinatorDegree && value)
                {
                    this.examinatorDegree = true;
                }
            }
        }

        public BrownBelt()
        {
            this.name = "John";
            this.surname = "Dow";
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
            this.professor = null;
            this.payment = 0;
            this.competitionsScore = 0;
            Console.WriteLine("[BrownBelt constructor]");
        }

        public BrownBelt(string name, string surname, Professor professor, int payment, double competitionsScore = 0, bool examinatorDegree = false, int yearsPracticed = 0, int yearsSpentOnRelatedMartialArts = 0)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = yearsPracticed;
            this.yearsSpentOnRelatedMartialArts = yearsSpentOnRelatedMartialArts;
            this.professor = professor;
            this.payment = payment;
            this.examinatorDegree = examinatorDegree;

            if(competitionsScore >= 0 && competitionsScore <= 1)
            {
                this.competitionsScore = competitionsScore;
            }
            else if(competitionsScore > 1)
            {
                this.competitionsScore = 1;
            }
            else
            {
                this.competitionsScore = 0;
            }
            Console.WriteLine("[BrownBelt constructor]");
        }

        public override void Train()
        {
            int hours = CountHoursOfTraining(CompetitionScoreDevision.score);
            Console.WriteLine($"Trains for {hours} hours a week.");
        }

        private int CountHoursOfTraining(double competitionScoreDevision)
        {
            int normalHours = this.CountTrainingHoursBasedOnPayment();
            if(this.competitionsScore < competitionScoreDevision)
            {
                return (int)(normalHours*1.5);
            }
            return normalHours;
        }

        public void HelpProfessor()
        {
            Console.WriteLine("Helps professor.");
        }

        public override void WatchEducationalVideos()
        {
            Console.WriteLine("Watches 6 hours of educational videos a week.");
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
                    this.competitionsScore = 0;
                    this.examinatorDegree = false;
                }
                // if there were any unmanaged resourses, they would be cleaned up here
                this.disposed = true;
            }
        }
    }
}