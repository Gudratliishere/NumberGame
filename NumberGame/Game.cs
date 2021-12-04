using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    class Game
    {
        private int maxScore;
        private int criticPoint;
        private int average;

        private Random random = new Random();

        public int StepValue { get; private set; }
        public int Score { get; private set; } = 0;

        public Game(int maxScore)
        {
            this.maxScore = maxScore;
        }

        public void StartGame()
        {
            GenerateStepValue();
            DefineCriticPoint();
        }

        private void DefineCriticPoint()
        {
            average = StepValue + 1;
            criticPoint = maxScore % average;
        }

        private void GenerateStepValue()
        {
            if (maxScore < 2)
                StepValue = maxScore;
            else if (maxScore < 20)
                StepValue = 2;
            else if (maxScore < 30)
                StepValue = 3;
            else if (maxScore < 70)
                StepValue = maxScore / 10;
            else if (maxScore < 90)
                StepValue = 7;
            else
                StepValue = 8;
        }

        public int IncreaseScoreByAI()
        {
            if (criticPoint - Score <= 0)
                criticPoint += average;

            int increase;
            if (criticPoint - Score <= StepValue)
            {
                increase = criticPoint - Score;
                Score = criticPoint;
                criticPoint += average;
            }
            else
            {
                increase = random.Next(1, StepValue + 1); ;
                Score += increase;
            }
            return increase;
        }

        public void IncreaseScoreByUser(int value)
        {
            Score += value;
        }

        public bool IsGameFinished()
        {
            return maxScore == Score;
        }
    }
}
