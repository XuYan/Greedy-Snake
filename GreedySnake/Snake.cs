using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GreedySnake
{
    class Snake
    {
        GameConsole gameConsole;

        bool _shouldStop = false;

        Queue<Coordinate> body = new Queue<Coordinate>();
        public Direction direction;
        
        public SnakeState currentState;

        SnakeState normalState;
        SnakeState swimmingState;
        SnakeState breakingState;
        SnakeState fanaticState;

        Queue<Direction> directionChangeOps = new Queue<Direction>();

        SnakeState CurrentState
        {
            set 
            {
                PaintSnake(value.BodyColor);

                value.ResetEffectiveTime();
                value.CountDown();

                currentState = value;
            }
        }

        const string EAT_SELF = " Greedy snake just ate itself stupidly :(";
        const string DROWN_SELF = " Greedy snake just drown itself accidently :(";
        const string HIT_SELF = " Greedy snake just hit itself incautiously:(";

        public void RequestStop()
        {
            _shouldStop = true;
        }

        public Snake(GameConsole gameConsole)
        {
            this.gameConsole = gameConsole;

            InitializeSnake();
        }

        public void InitializeSnake()
        {
            _shouldStop = false;
            body.Clear();
            directionChangeOps.Clear();

            body.Enqueue(gameConsole.GetCoordinate(10, 1));
            body.Enqueue(gameConsole.GetCoordinate(10, 2));
            body.Enqueue(gameConsole.GetCoordinate(10, 3));
            direction = Direction.Right;

            normalState = new NormalState(this);
            swimmingState = new SwimmingState(this);
            breakingState = new BreakingState(this);
            fanaticState = new FanaticState(this);

            ResetState();

            PaintSnake(Color.Black);

            gameConsole.UpdateSnakeLength(body.Count());
        }

        public void PaintSnake(Color color)
        {
            foreach (Coordinate segment in body)
            {
                segment.ShownColor = color;
            }
        }

        public void ResetState()
        {
            if (currentState == swimmingState)
            {
                CurtailSnakeBody();
            }
            CurrentState = normalState;
        }

        // If part of the snake is drown, curtail from the beginning of the drown part
        // If snake length after this method is called is zero, the snake is fully drown and terminate the game
        void CurtailSnakeBody() {
            Queue<Coordinate> new_body = new Queue<Coordinate>();
            foreach (Coordinate segment in body)
            {
                if (segment.originalColor != Color.LightBlue)
                {
                    new_body.Enqueue(segment);
                }
                else
                {
                    break;
                }
                body = new_body;
            }
        }

        public void MoveForward()
        {
            while (!_shouldStop)
            {
                Coordinate new_HeadCoordinate = GetNextCoordinate(body.Last(), getDirection());
                if (EatSelf(new_HeadCoordinate))
                {
                    gameConsole.TerminateRunningThreads();
                    gameConsole.ShowGameOverWindow(EAT_SELF);
                    if (gameConsole.IsBetterRecordAchieved(body.Count()))
                    {
                        gameConsole.ShowNewRecordForm();
                    }
                    break;
                }

                if (new_HeadCoordinate.isFruitOccupied)
                {
                    EatFruit(new_HeadCoordinate);
                }
                else if (new_HeadCoordinate.IsBreakableBarrier())
                {
                    if (currentState == breakingState)
                    {
                        BreakBarrier(new_HeadCoordinate);
                    }
                    else
                    {
                        gameConsole.TerminateRunningThreads();
                        gameConsole.ShowGameOverWindow(HIT_SELF);
                        if (gameConsole.IsBetterRecordAchieved(body.Count()))
                        {
                            gameConsole.ShowNewRecordForm();
                        }
                    }
                }
                else if (new_HeadCoordinate.IsPool())
                {
                    if (currentState != swimmingState)
                    {
                        gameConsole.TerminateRunningThreads();
                        gameConsole.ShowGameOverWindow(DROWN_SELF);
                        if (gameConsole.IsBetterRecordAchieved(body.Count()))
                        {
                            gameConsole.ShowNewRecordForm();
                        }
                    }
                }
                else if (new_HeadCoordinate.IsFence())
                {
                    gameConsole.TerminateRunningThreads();
                    gameConsole.ShowGameOverWindow(HIT_SELF);
                    if (gameConsole.IsBetterRecordAchieved(body.Count()))
                    {
                        gameConsole.ShowNewRecordForm();
                    }
                }
                else
                {
                    IncludeHead(new_HeadCoordinate);
                    ExcludeTail();
                }

                Thread.Sleep(1000 / currentState.Speed);
            }
        }

        Direction getDirection()
        {
            direction = directionChangeOps.Count != 0 ? directionChangeOps.Dequeue() : direction;
            return direction;
        }

        public Coordinate GetNextCoordinate(Coordinate snakeHead, Direction dir)
        {
            int new_row = snakeHead.row;
            int new_col = snakeHead.col;
            switch (dir)
            {
                case Direction.Up:
                    new_row -= 1;
                    break;
                case Direction.Down:
                    new_row += 1;
                    break;
                case Direction.Left:
                    new_col -= 1;
                    break;
                default:
                    new_col += 1;
                    break;
            }

            return gameConsole.GetCoordinate(new_row, new_col);
        }

        bool EatSelf(Coordinate next_HeadCoordinate)
        {
            return next_HeadCoordinate.ShownColor == Color.Black;
        }

        void EatFruit(Coordinate next_HeadCoordinate)
        {
            Fruit fruit = gameConsole.fruitGenerator.GetFruitFromCoordinate(next_HeadCoordinate);
            
            next_HeadCoordinate.ResetCoordinate();
            IncludeHead(next_HeadCoordinate);

            ChangeState(fruit.FruitType);

            if (!fruit.FruitType.shouldSnakeGrow())
            {
                ExcludeTail();
            }
            else
            {
                gameConsole.UpdateSnakeLength(body.Count());
            }

            fruit.StopRunningTimers();

            FruitDisappearEventArgs args = new FruitDisappearEventArgs();
            args.fruitCoordinateArg = next_HeadCoordinate;
            gameConsole.fruitGenerator.GenerateNewFruit(this, args);
        }

        void ChangeState(FruitType fruitType)
        {
            switch (fruitType)
            {
                case FruitType.Strawberry:
                    CurrentState = fanaticState;
                    break;
                case FruitType.Banana:
                    CurrentState = breakingState;
                    break;
                case FruitType.Blueberry:
                    CurrentState = swimmingState;
                    break;
                default:
                    // When an orange is eaten, state shouldn't change. 
                    // Snake color needs to remain
                    break;
            }
        }

        void BreakBarrier(Coordinate barrier)
        {
            barrier.originalColor = Color.Green;
            barrier.ShownColor = Color.Green;
        }

        void IncludeHead(Coordinate head)
        {
            head.ShownColor = body.Peek().ShownColor; // Cannot assign currentState.BodyColor because the snake may be flashing
            body.Enqueue(head);
        }

        void ExcludeTail()
        {
            Coordinate tail = body.Dequeue();
            tail.ShownColor = tail.originalColor;
        }

        public void AddDirectionChangeOperation(Direction toDir)
        {
            Direction fromDir = (directionChangeOps.Count != 0) ? directionChangeOps.Last() : direction;
            if (isEffectiveOp(fromDir, toDir))
            {
                directionChangeOps.Enqueue(toDir);
            }
        }

        bool isEffectiveOp(Direction fromDir, Direction toDir)
        {
            if (fromDir == Direction.Up || fromDir == Direction.Down)
            {
                return toDir != Direction.Up && toDir != Direction.Down;
            }
            else
            {
                return toDir != Direction.Left && toDir != Direction.Right;
            }
        }

        public int GetLength()
        {
            return body.Count();
        }
    }

    enum Direction
    {
        Up, Down, Left, Right, Unknown
    };

}