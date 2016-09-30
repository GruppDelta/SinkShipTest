using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinkShipTest
{
    class Ship
    {
        #region variables
        private int shipHeight;
        private int shipWidth;
        private int shipPositionX;
        private int shipPositionY;
        #endregion

        #region properties
        public int ShipHeight
        {
            get { return shipHeight; }
        }
        public int ShipWidth
        {
            get { return shipWidth; }
        }
        public int ShipPositionX
        {
            get { return shipPositionX; }
            set { shipPositionX = value; }
        }
        public int ShipPositionY
        {
            get { return shipPositionY; }
            set { shipPositionY = value; }
        }
        #endregion

        public Ship(int inputShipLength, int inputShipWidth)
        {
            shipHeight = inputShipLength;
            shipWidth = inputShipWidth;
        }
    }
}
