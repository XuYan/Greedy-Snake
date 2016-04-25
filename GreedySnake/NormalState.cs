using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedySnake
{
    class NormalState : SnakeState
    {
        public NormalState(Snake snake)
        {
            this.snake = snake;
            Speed = 3;
            EffectiveTime = Int32.MaxValue;
            BodyColor = Color.Black;

            InitializeCountDownTimer();
        }

        public override void ResetEffectiveTime()
        {
            EffectiveTime = Int32.MaxValue;
        }
    }
}
