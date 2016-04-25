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
    public partial class RecordDisplayForm : Form
    {
        public RecordDisplayForm(RecordGroup mapRecords)
        {
            InitializeComponent();

            ChangeFormTitle(mapRecords.mapName);
            PopulateRecords(mapRecords.records);
        }

        void ChangeFormTitle(string title)
        {
            MapName.Text = title;
        }

        void PopulateRecords(SortedSet<GameRecord> records)
        {
            GameRecord r1 = null, r2 = null, r3 = null;

            foreach (GameRecord r in records)
            {
                if (r1 == null)
                {
                    r1 = r;
                }
                else if (r2 == null)
                {
                    r2 = r1;
                    r1 = r;
                }
                else
                {
                    r3 = r2;
                    r2 = r1;
                    r1 = r;
                }
            }

            if (r1 != null)
            {
                name1.Text = r1.Name;
                length1.Text = r1.SnakeLength.ToString();
                date1.Text = r1.Date.ToString();
            }
            if (r2 != null)
            {
                name2.Text = r2.Name;
                length2.Text = r2.SnakeLength.ToString();
                date2.Text = r2.Date.ToString();
            }
            if (r3 != null)
            {
                name3.Text = r3.Name;
                length3.Text = r3.SnakeLength.ToString();
                date3.Text = r3.Date.ToString();
            }
        }

        void Okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
