﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorKonsolowy
{
    class CalculationType
    {
        protected static double result;
        public static void Calculate(ref char sign, ref double x, ref double y) {
            switch (sign){
                case '+' :
                    result =  x + y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '%':
                    result = x % y;
                    break;
            }
        } 
    }
}
