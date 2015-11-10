﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    public interface ITeam
    {
        int Points { get; set; }
        int Score { get; }
        string ScoreAsString { get; }
        void AwardPoint();
    }
}
