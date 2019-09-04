using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Shapes
{
    public class Line : ILength
    {
        public Point StartPoint { get;  set; }
        public Point EndPoint { get;  set; }
        public Line(Point point1, Point point2)
        {
            StartPoint = point1;
            EndPoint = point2;
        }
        public Line() { }
        public virtual double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow((EndPoint.X - StartPoint.X), 2)
                                 + Math.Pow((EndPoint.Y - StartPoint.Y), 2));
            }
        }
        public void Save(string path)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Line));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, this);
                    xml = sww.ToString(); 
                }
            }

            using (var writetext = new StreamWriter(path))
            {
                writetext.WriteLine(xml);
            }
        }
    }
} 
