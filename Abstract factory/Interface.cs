using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    public interface Interface
    {
        void Draw(Graphics g);
    }

    public class FiguresR : Interface
    {
        public void Draw(Graphics g)
        {

            g.FillEllipse(Brushes.Red, 210, 10, 100, 100); 
            g.FillRectangle(Brushes.Red, 110, 10, 100, 100);
            Point[] points = { new Point(60, 10), new Point(10, 110), new Point(110, 110) };
            g.FillPolygon(Brushes.Red, points);
        }
    }


    public class FiguresB: Interface
    {
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Blue, 210, 10, 100, 100); 
            g.FillRectangle(Brushes.Blue, 110, 10, 100, 100);
            Point[] points = { new Point(60, 10), new Point(10, 110), new Point(110, 110) };
            g.FillPolygon(Brushes.Blue, points);
        }
    }

    public class FiguresG: Interface
    {
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Green, 210, 10, 100, 100); 
            g.FillRectangle(Brushes.Green, 110, 10, 100, 100);
            Point[] points = { new Point(60, 10), new Point(10, 110), new Point(110, 110) };
            g.FillPolygon(Brushes.Green, points);
        }
    }
    public class FiguresY : Interface
    {
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Yellow, 210, 10, 100, 100); 
            g.FillRectangle(Brushes.Yellow, 110, 10, 100, 100);
            Point[] points = { new Point(60, 10), new Point(10, 110), new Point(110, 110) };
            g.FillPolygon(Brushes.Yellow, points);
        }
    }
}
   
