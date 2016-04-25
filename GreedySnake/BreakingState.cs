using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    class BreakingState : SnakeState
    {
        public BreakingState(Snake snake)
        {
            this.snake = snake;
            Speed = 1;
            EffectiveTime = 15;
            BodyColor = Color.Yellow;

            InitializeCountDownTimer();
        }

        public override void ResetEffectiveTime()
        {
            EffectiveTime = 15;
        }
    }
}
