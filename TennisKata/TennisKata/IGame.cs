using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public interface IGame
    {
        void AwardPoint(int teamNumber);
        bool GameOver();
        string GetWinner();
        string GetScore();
        bool IsDeuce();
        void Reset();
    }
}
