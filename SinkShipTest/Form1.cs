using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinkShipTest
{
    public partial class Play : Form
    {
        public const int gameSize = 10;
        public const int columnWidthSize = 22;
        public const string columnNameOne = "PLAYER ONE                                           ";
        public const string columnNameTwo = "PLAYER TWO                                           ";

        public Play()
        {
            InitializeComponent();

            PlayerOneGrid.Columns.Add(new DataGridViewButtonColumn());
            PlayerTwoGrid.Columns.Add(new DataGridViewButtonColumn());

            while (PlayerOneGrid.Rows.Count < gameSize)
            {
                PlayerOneGrid.Columns.Add(new DataGridViewButtonColumn());
                PlayerTwoGrid.Columns.Add(new DataGridViewButtonColumn());
                PlayerOneGrid.Rows.Add();
                PlayerTwoGrid.Rows.Add();
            }

            foreach (DataGridViewColumn column in PlayerOneGrid.Columns)
            {
                column.Width = columnWidthSize;
                column.HeaderText = columnNameOne[column.Index].ToString();
            }

            foreach (DataGridViewColumn column in PlayerTwoGrid.Columns)
            {
                column.Width = columnWidthSize;
                column.HeaderText = columnNameTwo[column.Index].ToString();
            }
        }
        private void PlayerOneGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnPlayer = e.ColumnIndex;
            int rowPlayer = e.RowIndex;

            Console.WriteLine("Clicked: " + "X:" + columnPlayer + " Y:" + rowPlayer);
            PlayerOneGrid[columnPlayer, rowPlayer].Style.BackColor = Color.Red;
        }

        private void PlayerTwoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnPlayer = e.ColumnIndex;
            int rowPlayer = e.RowIndex;

            Console.WriteLine("Clicked: " + "X:" + columnPlayer + " Y:" + rowPlayer);
            //PlayerTwoGrid[columnPlayer, rowPlayer].Style.BackColor = Color.Black;
            Game.player2.mediumShip.ShipPositionX = rowPlayer;
            Game.player2.mediumShip.ShipPositionY = columnPlayer;
            UpdateShip(Game.player2.mediumShip);
        }
        private void UpdateShip(Ship ship)
        {
            for (int i = 0; i < ship.ShipHeight; i++)
            {
                for (int j = 0; j < ship.ShipWidth; j++)
                {
                    PlayerTwoGrid[ship.ShipPositionY + i, ship.ShipPositionX + j].Style.BackColor = Color.Black;
                }
            }
        }
    }
}
