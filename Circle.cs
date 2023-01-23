using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_objects
{
    //Create a class named Circle to store the data about this circle. This class should contain these constructors and methods:
    public class Circle
    {
        //Properties
        private double Radius { get; set; }
        public string Circumference { get; set; }
        public string Area { get; set; }

        //constructors
        public Circle(double _radius)
        {
            //Define a member called radius. This member should be private. 
            Radius = _radius;
            Circumference = CalculateFormattedCircumference();
            Area = CalculateFormattedArea();
        }
        //methods
        public double CalculateCircumference()
        {
            return 2 * Radius * Math.PI;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
        public string GetDetails()
        {
            return $"The number you entered {Radius} creates a circle with an area of {Area} and a circumference of {Circumference}";
        }


    }
}
