using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GreedySnake
{
    abstract class SnakeState
    {
        protected Snake snake;

        Timer CountDownTimer = new Timer();

        bool flashingFlag = true;

        public int Speed
        {
            get;
            set;
        }

        public int EffectiveTime
        {
            get;
            set;
        }

        public Color BodyColor
        {
            get;
            set;
        }

        protected void InitializeCountDownTimer()
        {
            CountDownTimer.Interval = 1000;
            CountDownTimer.Elapsed += CountDownHelper;
        }
        
        public void CountDown()
        {
            CountDownTimer.Start();
        }

        void CountDownHelper(Object sender, System.Timers.ElapsedEventArgs args)
        {
            if (EffectiveTime <= 5)
            {
                FlipSnakeBodyColor();

                if (EffectiveTime == 0)
                {
                    CountDownTimer.Stop();
                    snake.ResetState();
                }
            }
            
            EffectiveTime -= 1;
        }

        void FlipSnakeBodyColor()
        {
            if (flashingFlag)
            {
                snake.PaintSnake(Color.Black);
            }
            else
            {
                snake.PaintSnake(BodyColor);
            }

            flashingFlag = !flashingFlag;
        }

        public void StopCountDownTimer()
        {
            CountDownTimer.Stop();
        }

        public abstract void ResetEffectiveTime();
    }
}
