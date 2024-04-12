using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;

        public float HighScore
        {
            get 
            {
                return highScore;
            }
            set
            {
                if (value > highScore) highScore = value;
            }
        }
        private int playedGames;
        private int wonGames;

        public string readonly Name;

        public  float WinRate
        {
            get
            {
                if (playedGames == 0 || wonGames == 0)
                {
                    return 0;
                }
                else
                {
                    return  wonGames / playedGames;
                }
            }
        }

        public Player(string name)
        {
            Name = name;
            highScore = 0;
            wonGames = 0;
            playedGames = 0;
        }

        public void PlayGame(bool win)
        {
            playedGames++;
            if (win) wonGames++;
        }
    }
}