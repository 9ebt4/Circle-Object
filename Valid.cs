using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace circle_objects
{
    //Create a class named Validator and use its static methods to validate the data in this application.

    public class Valid
    {
        public static double DoubleValidator()
        {
            double radius = 0;
            while (!double.TryParse(Console.ReadLine(), out radius) || radius < 0 || radius > double.MaxValue)
            {
                Console.WriteLine("Please use only positive numbers.");
            }
            return radius;
        }
        
}
}
