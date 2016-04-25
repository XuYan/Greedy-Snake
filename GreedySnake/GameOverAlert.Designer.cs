namespace GreedySnake
{
    partial class GameOverAlert
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
            this.GameOverAlertText = new System.Windows.Forms.Label();
            this.play_again_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameOverAlertText
            // 
            this.GameOverAlertText.AutoSize = true;
            this.GameOverAlertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverAlertText.Location = new System.Drawing.Point(12, 9);
            this.GameOverAlertText.Name = "GameOverAlertText";
            this.GameOverAlertText.Size = new System.Drawing.Size(117, 24);
            this.GameOverAlertText.TabIndex = 0;
            this.GameOverAlertText.Text = "Game Over! ";
            // 
            // play_again_button
            // 
            this.play_again_button.Location = new System.Drawing.Point(54, 47);
            this.play_again_button.Name = "play_again_button";
            this.play_again_button.Size = new System.Drawing.Size(75, 23);
            this.play_again_button.TabIndex = 1;
            this.play_again_button.Text = "Play  Again !";
            this.play_again_button.UseVisualStyleBackColor = true;
            this.play_again_button.Click += new System.EventHandler(this.play_again_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(344, 47);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // GameOverAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 56);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.play_again_button);
            this.Controls.Add(this.GameOverAlertText);
            this.Location = new System.Drawing.Point(400, 300);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOverAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameOverAlert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameOverAlertText;
        private System.Windows.Forms.Button play_again_button;
        private System.Windows.Forms.Button cancel_button;
    }
}