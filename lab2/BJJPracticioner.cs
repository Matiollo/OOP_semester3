using System;

namespace lab2
{
    public class BJJPracticioner : Fighter, IDisposable, IMember, IHuman
    {
        protected int yearsPracticed;
        protected int yearsSpentOnRelatedMartialArts;
        protected bool disposed = false;
        protected bool joinedGroup = false;

        public int YearsPracticed
        {
            get
            {
                return this.yearsPracticed;
            }
            set
            {
                if(value > this.yearsPracticed)
                {
                    this.yearsPracticed = value;
                }
            }
        }

        public int YearsSpentOnRelatedMartialArts
        {
            get
            {
                return this.yearsSpentOnRelatedMartialArts;
            }
            set
            {
                if(value >= 0)
                {
                    this.yearsSpentOnRelatedMartialArts = value;
                }
            }
        }

        public BJJPracticioner()
        {
            this.name = "John";
            this.surname = "Dow";
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
        }
        
        public BJJPracticioner(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = 0;
            this.yearsSpentOnRelatedMartialArts = 0;
        }

        public BJJPracticioner(string name, string surname, int yearsPracticed, int yearsSpentOnRelatedMartialArts = 0)
        {
            this.name = name;
            this.surname = surname;
            this.yearsPracticed = yearsPracticed;
            this.yearsSpentOnRelatedMartialArts = yearsSpentOnRelatedMartialArts;
        }
        
        public virtual void Train()
        {
            Console.WriteLine("Trains for 6 hours a week.");
        }

        public void Eat()
        {
            Console.WriteLine("Eats 3 times a day and snacks after trainings.");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeps for 8 hours a day.");
        }

        public void Shower()
        {
            Console.WriteLine("Showers sometimes.");
        }

        public void CommunicateWithOtherMembers()
        {
            Console.WriteLine("Communicates with other BJJ practitioners.");
        }

        public void JoinGroupChat()
        {
            if(!joinedGroup)
            {
                Console.WriteLine("Joined group chat.");
                joinedGroup = true;
                return;
            }
            Console.WriteLine("Already is a member of the group chat."); 
        }

        public void LeaveGroupChat()
        {
            if(joinedGroup)
            {
                Console.WriteLine("Left group chat.");
                joinedGroup = false;
                return;
            }
            Console.WriteLine("The practitioner isn't a member of any group chats."); 
        }

        public override void DoTechniques()
        {
            Console.WriteLine("Rolls.");
        }

        public override void WorkOut()
        {
            Console.WriteLine("Works out.");
        }

        public void Dispose()
        {
            this.CleanUp(true);
            // Console.WriteLine("[Disposing]");
            // Console.WriteLine("[Object is clearnd up.]");
            GC.SuppressFinalize(this);
            // Console.WriteLine("[Finalization suppressed]");
        }

        ~BJJPracticioner()
        {
            this.CleanUp(false);
            // Console.WriteLine("[Finalization]");
        }

        protected virtual void CleanUp(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
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