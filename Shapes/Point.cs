using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shapes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point() { }
        public Point(string path)
        {
            using (var streamReader = new StreamReader(path))
            {
                var text = streamReader.ReadToEnd();
                var xIndex = text.IndexOf("x=") + 2;
                var yIndex = text.IndexOf("y=") + 2;
                var xStr = text.Substring(xIndex, text.IndexOf(",") - xIndex);
                var yStr = text.Substring(yIndex, text.Length - yIndex);
                X = int.Parse(xStr);
                Y = int.Parse(yStr);
            }
        }
        public void Save(string path)
        {
            using (var writetext = new StreamWriter(path))
            {
                writetext.WriteLine(string.Format("x={0}, y={1}", X, Y));
            }
        }
    }
}
