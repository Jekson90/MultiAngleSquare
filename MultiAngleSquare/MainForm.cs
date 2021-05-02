using MultiAngleSquare.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiAngleSquare
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double s = Calculator.Calculate(GetPoints());
            squareLabel.Text = $"S = {s}";
        }

        private List<Data.Point> GetPoints()
        {
            if (pointsDataGrid.RowCount == 1)
                return null;

            List<Data.Point> points = new List<Data.Point>();
            for (int i = 0; i < pointsDataGrid.RowCount-1; i++)
            {
                double x;
                double y;
                try
                {
                    x = Convert.ToDouble(pointsDataGrid[0, i].Value);
                    y = Convert.ToDouble(pointsDataGrid[1, i].Value);
                }
                catch (FormatException e)
                {
                    continue;
                }
                points.Add(new Data.Point(x, y));
            }

            return points;
        }
    }
}
