using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    class SwimmingState : SnakeState
    {
        public SwimmingState(Snake snake)
        {
            this.snake = snake;
            Speed = 1;
            EffectiveTime = 20;
            BodyColor = Color.Blue;

            InitializeCountDownTimer();
        }

        public override void ResetEffectiveTime()
        {
            EffectiveTime = 20;
        }
    }
}
