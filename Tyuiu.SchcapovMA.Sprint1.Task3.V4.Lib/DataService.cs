﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SchcapovMA.Sprint1.Task3.V4.Lib
{
    public class DataService : ISprint1Task3V4
    {
        public double PurchaseAmount(double priceNotebook, double priceCover, int quantity)
        {
            return Math.Round((priceNotebook + priceCover)* quantity,3);
        }
    }
}
