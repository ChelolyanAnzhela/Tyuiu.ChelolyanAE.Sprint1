﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChelolyanAE.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            int h = int.Parse(k.ToString().Skip(k.ToString().Length - 3).FirstOrDefault().ToString());
            return h;
        }
    }
}
