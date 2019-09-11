using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Shapes
{
    public class Triangle : ILength
    {
        public Line LineAB { get; set; }
        public Line LineBC { get; set; }
        public Line LineCA { get; set; }
        public Triangle() { }
        public Triangle(Point a, Point b, Point c)
        {
            LineAB = new Line(a, b);
            LineBC = new Line(b, c);
            LineCA = new Line(c, a);
        }
        public Triangle(Line ab, Line bc, Line ca)
        {
            LineAB = ab;
            LineBC = bc;
            LineCA = ca;
        }
        public Triangle(string path)
        {
            using (var streamReader = new StreamReader(path))
            {
                var text = streamReader.ReadToEnd();
                var newTriangle = JsonConvert.DeserializeObject<Triangle>(text);
                LineAB = newTriangle.LineAB;
                LineBC = newTriangle.LineBC;
                LineCA = newTriangle.LineCA;
            }
        }
        public void Save(string path)
        {
            string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            using (var writetext = new StreamWriter(path))
            {
                writetext.WriteLine(json);
            }
        }
        public double Length
        {
            get
            {
                return LineAB.Length + LineBC.Length + LineCA.Length;
            }
        }
        public double Square
        {
            get
            {
                return Math.Sqrt((Length / 2)
                              * ((Length / 2) - LineAB.Length)
                              * ((Length / 2) - LineBC.Length)
                              * ((Length / 2) - LineCA.Length));
            }
        }
    }
}
