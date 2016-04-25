using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GreedySnake
{
    public partial class GameConsole : Form
    {
        // TODO: Move to configuration file
        int gameTime = 120;

        RecordGroup yellowStoneMapRecord;
        RecordGroup grandCanyonMapRecord;

        Coordinate[,] mapLayout;
        
        Snake snake;
        internal FruitGenerator fruitGenerator;

        Thread SnakeMovingThread;
        Thread FruitGenerationThread;

        public GameConsole()
        {
            InitializeComponent();

            InitializeMapLayout();
            ReadRecordGroupFromDisk();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void GameClockTicks(object sender, EventArgs e)
        {
            if (gameTime <= 0)
            {
                TerminateRunningThreads();
                ShowGameOverWindow("Time Running Out:) Snake Length: " + snake.GetLength());
                if (IsBetterRecordAchieved(snake.GetLength()))
                {
                    ShowNewRecordForm();
                }
            }
            Game_Time_Label.Text = gameTime.ToString();
            gameTime -= 1;
        }

        delegate void UpdateSnakeLengthCallback(int length);
        public void UpdateSnakeLength(int length)
        {
            // If the method is not invoked by the thread that created the label, InvokeRequired returns true 
            if (Snake_Length_Label.InvokeRequired)
            {
                UpdateSnakeLengthCallback callback = new UpdateSnakeLengthCallback(UpdateSnakeLength);
                Invoke(callback, new Object[] { length });
            }
            else
            {
                Snake_Length_Label.Text = length.ToString();
            }
        }

        public void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeMapLayout();

            CreateSnake();
            CreateFruitGenerator();

            SnakeMovingThread = new Thread(snake.MoveForward);
            SnakeMovingThread.Start();

            FruitGenerationThread = new Thread(fruitGenerator.Generate);
            FruitGenerationThread.Start();

            RestartGameTimer(GameTimer);

            this.Refresh();
        }

        void RestartGameTimer(System.Windows.Forms.Timer GameTimer)
        {
            this.gameTime = 120;
            GameTimer.Start();
        }

        void yellowStoneRankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RecordDisplayForm(yellowStoneMapRecord).Show(this);
        }

        void grandCanyonRankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RecordDisplayForm(grandCanyonMapRecord).Show(this);
        }

        void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HowToPlayForm().Show(this);
        }

        void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show(this);
        }

        delegate void ShowGameOverWindowCallback(string reason);
        public void ShowGameOverWindow(String reason)
        {
            if (this.InvokeRequired)
            {
                ShowGameOverWindowCallback callback = new ShowGameOverWindowCallback(ShowGameOverWindow);
                Invoke(callback, new Object[] { reason });
            }
            else
            {
                new GameOverAlert(this, reason).Show(this);
            }
        }

        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm if user wants to exit
            switch (MessageBox.Show(
                this, "Are you sure to exit GreedySnake?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    TerminateRunningThreads();
                    WriteRecordGroupToDisk();
                    break;
            }
        }

        void WriteRecordGroupToDisk()
        {
            yellowStoneMapRecord.WriteRecordsToFile("YellowStone");
            grandCanyonMapRecord.WriteRecordsToFile("GrandCanyon");
        }

        void RepaintMap()
        {
            InitializeMapLayout();
            this.Refresh();
        }

        void InitializeMapLayout()
        {
            this.mapLayout = MapFactory.CreateMap(ReadGameProperties(), PaintAt).Create();
        }

        void ReadRecordGroupFromDisk()
        {
            yellowStoneMapRecord = new YellowStoneMapRecords();
            grandCanyonMapRecord = new GrandCanyonMapRecords();

        }

        public bool IsBetterRecordAchieved(int snakeLength)
        {
            GameRecord currentResult = new GameRecord("", snakeLength, DateTime.Now);
            string selectedMap = ReadGameProperties();
            if (selectedMap == "Yellow Stone")
            {
                return yellowStoneMapRecord.IsBetterRecord(currentResult);
            }
            else
            {
                return grandCanyonMapRecord.IsBetterRecord(currentResult);
            }
        }

        delegate void ShowNewRecordFormCallback();
        public void ShowNewRecordForm()
        {
            GameRecord currentResult = new GameRecord("", snake.GetLength(), DateTime.Now);
            string selectedMap = ReadGameProperties();
            if (selectedMap == "Yellow Stone")
            {
                currentResult.TargetGroup = yellowStoneMapRecord;
            }
            else
            {
                currentResult.TargetGroup = grandCanyonMapRecord;
            }

            if (this.InvokeRequired)
            {
                ShowNewRecordFormCallback callback = new ShowNewRecordFormCallback(ShowNewRecordForm);
                Invoke(callback);
            }
            else
            {
                new NewRecordForm(currentResult).Show(this);
            }
            
        }

        string ReadGameProperties()
        {
            String defaultMap = Properties.Settings.Default.Map;
            if (defaultMap == "Yellow Stone")
            {
                yellowStoneToolStripMenuItem.Checked = true;
            }
            else
            {
                grandCanyonToolStripMenuItem.Checked = true;
            }
            // TODO: Leave for future map extension

            Debug.WriteLine(defaultMap);

            return defaultMap;
        }

        void OnYellowStoneSelected(object sender, EventArgs e)
        {
            yellowStoneToolStripMenuItem.Checked = true;
            grandCanyonToolStripMenuItem.Checked = false;

            Properties.Settings.Default.Map = "Yellow Stone";

            InitializeMapLayout();
            this.Refresh();
        }

        void OnGrandCanyonSelected(object sender, EventArgs e)
        {
            yellowStoneToolStripMenuItem.Checked = false;
            grandCanyonToolStripMenuItem.Checked = true;

            Properties.Settings.Default.Map = "Grand Canyon";

            InitializeMapLayout();
            this.Refresh();
        }

        public void CreateSnake()
        {
            this.snake = new Snake(this);
        }

        public void CreateFruitGenerator()
        {
            this.fruitGenerator = new FruitGenerator(mapLayout);
        }

        public void TerminateRunningThreads()
        {
            GameTimer.Stop();

            if (SnakeMovingThread != null && SnakeMovingThread.IsAlive)
            {
                snake.RequestStop();
            }

            if (FruitGenerationThread != null && FruitGenerationThread.IsAlive)
            {
                fruitGenerator.RequestStop();
            }

            if (snake != null)
            {
                snake.currentState.StopCountDownTimer();
            }

            if (fruitGenerator != null)
            {
                foreach (Fruit fruit in fruitGenerator.coordinate_fruit_mapping.Select(mapping => mapping.Value))
                {
                    fruit.StopRunningTimers();
                }
            }
        }

        void PaintMap(object sender, PaintEventArgs e)
        {
            for (int row = 0; row < Map.ROW_COUNT; row++)
            {
                for (int col = 0; col < Map.COL_COUNT; col++)
                {
                    PaintAt(mapLayout[row, col]);
                }
            }
        }
        
        /// <summary>
        /// Fill the rectange at (row, col) with given color
        /// </summary>
        /// <param name="position">Coordinate of the rectangle to be painted</param>
        public void PaintAt(Coordinate position)
        {
            Graphics graphics = this.CreateGraphics();
            int leftOffset = 4;
            int topOffset = 28;
            Brush brushColor = Brushes.LawnGreen;
            switch (position.ShownColor)
            {
                case Color.Green:
                    brushColor = Brushes.LawnGreen;
                    break;
                case Color.Brown:
                    brushColor = Brushes.Maroon;
                    break;
                case Color.Black:
                    brushColor = Brushes.Black;
                    break;
                case Color.Red:
                    brushColor = Brushes.Crimson;
                    break;
                case Color.Yellow:
                    brushColor = Brushes.Gold;
                    break;
                case Color.Blue:
                    brushColor = Brushes.DarkBlue;
                    break;
                case Color.Orange:
                    brushColor = Brushes.DarkOrange;
                    break;
                case Color.LightBlue:
                    brushColor = Brushes.DodgerBlue;
                    break;
                case Color.Grey:
                    brushColor = Brushes.DimGray;
                    break;
                default:
                    // TODO: Add brush color for other cases
                    break;

            }
            graphics.FillRectangle(
                brushColor, 
                new Rectangle(leftOffset + position.col * 20 + 10, topOffset + position.row * 20 + 10, 19, 19));
        }

        public Coordinate GetCoordinate(int row, int col)
        {
            return mapLayout[row, col];
        }

        void GameConsole_KeyDown(object sender, KeyEventArgs keyPressed)
        {
            Direction new_direction = Direction.Unknown;
            switch (keyPressed.KeyCode)
            {
                case Keys.Up:
                    new_direction = Direction.Up;
                    break;
                case Keys.Down:
                    new_direction = Direction.Down;
                    break;
                case Keys.Left:
                    new_direction = Direction.Left;
                    break;
                case Keys.Right:
                    new_direction = Direction.Right;
                    break;
                default:
                    // Nothing happens when other keys are pressed
                    break;
            }

            if (new_direction != Direction.Unknown)
            {
                snake.AddDirectionChangeOperation(new_direction);
            }
        }
    }
}
