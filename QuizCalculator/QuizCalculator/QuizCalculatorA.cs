//Written by Mahlet Gebremedhin
//1/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuizCalculator
{
    public class QuizCalculatorA
    {
        // class variables 
        private double quiz1 = -9999.99;
        private double quiz2 = -9999.99;
        private double quiz3 = -9999.99;
        private double quiz4 = -9999.99;
        //private double total = -9999.99;
        //private double average = -39999.96;
        //private string lettergrade = "n/a";

        // gets and sets 

        public double Quiz1
        {
            get { return this.quiz1; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz1 = -9999.99;
                }
                else
                {
                    this.quiz1 = value;
                }
            }
        }

        public double Quiz2
        {
            get { return this.quiz2; }
            set
            {
                if (value > 100.0 || value < 0.0)


                {
                    this.quiz2 = value;
                }
                else
                {
                    this.quiz2 = value;
                }

            }
        }
        public double Quiz3
        {
            get { return this.quiz3; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz3 = value;

                }
                else
                { this.quiz3 = value; }
            }

                
        }
        public double Quiz4
        {
            get { return this.quiz4; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz4 = value;
                }
                else
                {
                    this.quiz4 = value;
                }
            }

                
        }


        //methods 

        

        public double CalcTotal()
        {
            double aTotal = 0.0;

            aTotal = Quiz1 + Quiz2 + Quiz3 + Quiz4;
            return aTotal;

        }

    
    public double CalcAverage()
        {
            double aAverage = 0.0;
            // the 4 is a classic "majic number"


            aAverage = (Quiz1 + Quiz2 + Quiz3 + Quiz4)/4.0;
            return aAverage;

           
        }
        public string CalcLetterGrade()
        {
            double anAverage = 0.0;
            string aLetterGrade = "n/a";

            anAverage = (Quiz1 + Quiz2 + Quiz3 + Quiz4) / 4;
            if (anAverage >= 0.0 && anAverage < 60.0)

            {
                aLetterGrade = "F";
            }
            {

                if (anAverage >= 60.0 && anAverage < 70.0)
                    
                        aLetterGrade = "D";
            }

            
            { 
            if (anAverage >= 70.0 && < 90.0)
                
                    aLetterGrade = "B";
            }
            if (anAverage >= 90.0 && < 100.0)
            {
                aLetterGrade = "A";
            }

            return aLetterGrade;


            


            
        }

       


        

    }
}
