using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    class FanaticState : SnakeState
    {
        public FanaticState(Snake snake)
        {
            this.snake = snake;
            Speed = 3;
            EffectiveTime = 15;
            BodyColor = Color.Red;

            InitializeCountDownTimer();
        }

        public override void ResetEffectiveTime()
        {
            EffectiveTime = 15;
        }
    }
}
