using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public class Team : ITeam
    {
        private int points;

        public Team()
        {
            points = 0;
        }

        public string ScoreAsString
        {
            get
            {
                if (Points == 0) return "love";
                if (Points == 1) return "fifteen";
                if (Points == 2) return "thirty";
                if (Points > 2) return "forty";
                return "love";
            }
        }

        public int Score
        {
            get
            {
                if (Points == 0)
                    return 0;
                if (Points == 1)
                    return 15;
                if (Points == 2)
                    return 30;
                if (Points > 2)
                    return 40;
                return -1;
            }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public void AwardPoint()
        {
            Points++;
        }
    }
}
