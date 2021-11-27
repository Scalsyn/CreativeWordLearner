using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeWordLearner
{
    class User
    {
        public string name;
        public byte level;
        public short points;
        public int sumOfResults;
        public short playedRounds;

        public User(string name = "", byte level = 1, short points = 0, int sumOfResults = 0, short playedRounds = 0)
        {
            this.name = name;
            this.level = level;
            this.points = points;
            this.sumOfResults = sumOfResults;
            this.playedRounds = playedRounds;
        }

        public double Get_AverageResult => Math.Round((double)sumOfResults / playedRounds, 1);
    }
}
