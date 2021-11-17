using System;
using System.Collections.Generic;

namespace Code
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static double CircleDiameter(double area)
        {
            //you write this code
            throw new NotImplementedException();
        }

        public static double RightTriangleSideLength(double side1, double angle, double side2)
        {
            throw new NotImplementedException();
        }

        private static List<string> fileContents = new List<string>(){
            "Sally|62",
            "Frank|75",
            "Jessica|80",
            "Mary|95",
            "Henry|93",
            "Todd|97",
            "Hank|89",
            "Jane|95"
        };

        public static Results ProcessTestScores()
        {
            //Assign these values as you go through each line in the "fileName" file
            decimal averageScore = -1;
            decimal maxScore = -1;
            string maxScoreName = null;
            decimal minScore = -1;
            string minScoreName = null;

            foreach(var line in fileContents)
            {

            }
            
            return new Results(averageScore, maxScore, maxScoreName, minScore, minScoreName);
        }
    }

    public record Results(
        decimal AverageScore,
        decimal MaxScore,
        string MaxScoreName,
        decimal MinScore,
        string MinScoreName
    );
}
