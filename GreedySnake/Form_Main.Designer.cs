namespace GreedySnake
{
    partial class GameConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameConsole));
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowStoneRankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandCanyonRankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowStoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandCanyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Snake_Length_Label = new System.Windows.Forms.Label();
            this.Game_Time_Label = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Game_Timer = new System.Windows.Forms.PictureBox();
            this.Snake_Length = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            this.TableLayoutPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snake_Length)).BeginInit();
            this.SuspendLayout();
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.rankingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // rankingsToolStripMenuItem
            // 
            this.rankingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yellowStoneRankingToolStripMenuItem,
            this.grandCanyonRankingToolStripMenuItem});
            this.rankingsToolStripMenuItem.Name = "rankingsToolStripMenuItem";
            this.rankingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rankingsToolStripMenuItem.Text = "Rankings";
            // 
            // yellowStoneRankingToolStripMenuItem
            // 
            this.yellowStoneRankingToolStripMenuItem.Name = "yellowStoneRankingToolStripMenuItem";
            this.yellowStoneRankingToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.yellowStoneRankingToolStripMenuItem.Text = "Yellow Stone Ranking";
            this.yellowStoneRankingToolStripMenuItem.Click += new System.EventHandler(this.yellowStoneRankingToolStripMenuItem_Click);
            // 
            // grandCanyonRankingToolStripMenuItem
            // 
            this.grandCanyonRankingToolStripMenuItem.Name = "grandCanyonRankingToolStripMenuItem";
            this.grandCanyonRankingToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.grandCanyonRankingToolStripMenuItem.Text = "Grand Canyon Ranking";
            this.grandCanyonRankingToolStripMenuItem.Click += new System.EventHandler(this.grandCanyonRankingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToPlayToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.mapToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yellowStoneToolStripMenuItem,
            this.grandCanyonToolStripMenuItem});
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.mapToolStripMenuItem.Text = "Map";
            // 
            // yellowStoneToolStripMenuItem
            // 
            this.yellowStoneToolStripMenuItem.Name = "yellowStoneToolStripMenuItem";
            this.yellowStoneToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yellowStoneToolStripMenuItem.Text = "Yellow Stone";
            this.yellowStoneToolStripMenuItem.Click += new System.EventHandler(this.OnYellowStoneSelected);
            // 
            // grandCanyonToolStripMenuItem
            // 
            this.grandCanyonToolStripMenuItem.Name = "grandCanyonToolStripMenuItem";
            this.grandCanyonToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.grandCanyonToolStripMenuItem.Text = "Grand Canyon";
            this.grandCanyonToolStripMenuItem.Click += new System.EventHandler(this.OnGrandCanyonSelected);
            // 
            // TableLayoutPanel_Main
            // 
            this.TableLayoutPanel_Main.BackColor = System.Drawing.Color.White;
            this.TableLayoutPanel_Main.ColumnCount = 9;
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableLayoutPanel_Main.Controls.Add(this.Game_Timer, 7, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Snake_Length, 1, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Snake_Length_Label, 3, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Game_Time_Label, 5, 0);
            this.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel_Main.Location = new System.Drawing.Point(0, 623);
            this.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main";
            this.TableLayoutPanel_Main.RowCount = 1;
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_Main.Size = new System.Drawing.Size(1114, 48);
            this.TableLayoutPanel_Main.TabIndex = 2;
            // 
            // Snake_Length_Label
            // 
            this.Snake_Length_Label.AutoSize = true;
            this.Snake_Length_Label.CausesValidation = false;
            this.Snake_Length_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Snake_Length_Label.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snake_Length_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.Snake_Length_Label.Location = new System.Drawing.Point(99, 0);
            this.Snake_Length_Label.Name = "Snake_Length_Label";
            this.Snake_Length_Label.Size = new System.Drawing.Size(438, 48);
            this.Snake_Length_Label.TabIndex = 3;
            this.Snake_Length_Label.Text = "Snake Length";
            this.Snake_Length_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game_Time_Label
            // 
            this.Game_Time_Label.AutoSize = true;
            this.Game_Time_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game_Time_Label.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Time_Label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Game_Time_Label.Location = new System.Drawing.Point(575, 0);
            this.Game_Time_Label.Name = "Game_Time_Label";
            this.Game_Time_Label.Size = new System.Drawing.Size(438, 48);
            this.Game_Time_Label.TabIndex = 4;
            this.Game_Time_Label.Text = "Game Time";
            this.Game_Time_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameClockTicks);
            // 
            // Game_Timer
            // 
            this.Game_Timer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Game_Timer.BackgroundImage")));
            this.Game_Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Game_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game_Timer.Location = new System.Drawing.Point(1035, 3);
            this.Game_Timer.Name = "Game_Timer";
            this.Game_Timer.Size = new System.Drawing.Size(42, 42);
            this.Game_Timer.TabIndex = 3;
            this.Game_Timer.TabStop = false;
            // 
            // Snake_Length
            // 
            this.Snake_Length.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Snake_Length.BackgroundImage")));
            this.Snake_Length.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Snake_Length.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Snake_Length.Location = new System.Drawing.Point(35, 3);
            this.Snake_Length.Name = "Snake_Length";
            this.Snake_Length.Size = new System.Drawing.Size(42, 42);
            this.Snake_Length.TabIndex = 3;
            this.Snake_Length.TabStop = false;
            // 
            // GameConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1114, 671);
            this.Controls.Add(this.TableLayoutPanel_Main);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(80, 20);
            this.MaximizeBox = false;
            this.Name = "GameConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GreedySnake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMap);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameConsole_KeyDown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.TableLayoutPanel_Main.ResumeLayout(false);
            this.TableLayoutPanel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snake_Length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Main;
        private System.Windows.Forms.PictureBox Game_Timer;
        private System.Windows.Forms.PictureBox Snake_Length;
        private System.Windows.Forms.Label Snake_Length_Label;
        private System.Windows.Forms.Label Game_Time_Label;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.ToolStripMenuItem rankingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grandCanyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowStoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowStoneRankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grandCanyonRankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;

    }
}

