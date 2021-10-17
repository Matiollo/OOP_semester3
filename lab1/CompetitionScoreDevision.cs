using System;

namespace lab1
{
    public class CompetitionScoreDevision
    {
        public static readonly double score;

        static CompetitionScoreDevision()
        {
            // If the program was more advanced, constructor would download current statistic information 
            // and calculate the score based on this information.

            score = Math.PI / 10;
        }
    }
}