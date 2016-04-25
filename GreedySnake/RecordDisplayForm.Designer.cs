namespace GreedySnake
{
    partial class RecordDisplayForm
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
            this.MapName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Sequence = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            this.length1 = new System.Windows.Forms.Label();
            this.length2 = new System.Windows.Forms.Label();
            this.length3 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapName
            // 
            this.MapName.AutoSize = true;
            this.MapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapName.Location = new System.Drawing.Point(125, 18);
            this.MapName.Name = "MapName";
            this.MapName.Size = new System.Drawing.Size(116, 25);
            this.MapName.TabIndex = 0;
            this.MapName.Text = "Map Name";
            this.MapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.Sequence, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.name1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.name2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.name3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.length1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.length2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.length3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.date1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.date2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.date3, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 147);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Sequence
            // 
            this.Sequence.AutoSize = true;
            this.Sequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sequence.Location = new System.Drawing.Point(3, 0);
            this.Sequence.Name = "Sequence";
            this.Sequence.Size = new System.Drawing.Size(87, 36);
            this.Sequence.TabIndex = 0;
            this.Sequence.Text = "Sequence";
            this.Sequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(96, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(235, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Snake Length";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(328, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name1.Location = new System.Drawing.Point(96, 36);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(133, 36);
            this.name1.TabIndex = 7;
            this.name1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name2.Location = new System.Drawing.Point(96, 72);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(133, 36);
            this.name2.TabIndex = 8;
            this.name2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name3.Location = new System.Drawing.Point(96, 108);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(133, 39);
            this.name3.TabIndex = 9;
            this.name3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // length1
            // 
            this.length1.AutoSize = true;
            this.length1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.length1.Location = new System.Drawing.Point(235, 36);
            this.length1.Name = "length1";
            this.length1.Size = new System.Drawing.Size(87, 36);
            this.length1.TabIndex = 10;
            this.length1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // length2
            // 
            this.length2.AutoSize = true;
            this.length2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.length2.Location = new System.Drawing.Point(235, 72);
            this.length2.Name = "length2";
            this.length2.Size = new System.Drawing.Size(87, 36);
            this.length2.TabIndex = 11;
            this.length2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // length3
            // 
            this.length3.AutoSize = true;
            this.length3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.length3.Location = new System.Drawing.Point(235, 108);
            this.length3.Name = "length3";
            this.length3.Size = new System.Drawing.Size(87, 39);
            this.length3.TabIndex = 12;
            this.length3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date1.Location = new System.Drawing.Point(328, 36);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(135, 36);
            this.date1.TabIndex = 13;
            this.date1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date2.Location = new System.Drawing.Point(328, 72);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(135, 36);
            this.date2.TabIndex = 14;
            this.date2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date3.Location = new System.Drawing.Point(328, 108);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(135, 39);
            this.date3.TabIndex = 15;
            this.date3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Okay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Okay_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // RecordDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 250);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MapName);
            this.Location = new System.Drawing.Point(450, 220);
            this.Name = "RecordDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Record Display Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MapName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Sequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.Label length1;
        private System.Windows.Forms.Label length2;
        private System.Windows.Forms.Label length3;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}