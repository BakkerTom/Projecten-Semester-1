using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_App
{
    class Line
    {
        private int x;
        private int y;

        private int endX;
        private int endY;

        private Random rnd = new Random();

        public Line()
        {
            x = rnd.Next(946);
            y = rnd.Next(490);

            endX = rnd.Next(946);
            endY = rnd.Next(490);
        }

        public void drawLine(Graphics g)
        {
            Pen myPen = new Pen(Color.Salmon);
            myPen.Width = 5;

            g.DrawLine(myPen, x, y, endX, endY);
        }
    }
}
