using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreedySnake
{
    public partial class NewRecordForm : Form
    {
        GameRecord currentResult;

        public NewRecordForm(GameRecord currentResult)
        {
            InitializeComponent();

            this.currentResult = currentResult;
        }

        void Okay_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Count() == 0)
            {
                Warning.Text = "Cannot Left Empty";
                return;
            }
            else
            {
                currentResult.Name = NameTextBox.Text;
                currentResult.TargetGroup.AddRecord(currentResult);

                this.Close();
            }
        }
    }
}
