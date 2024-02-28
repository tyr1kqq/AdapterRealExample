﻿using AdapterRealExample.Devies;
using System;

namespace AdapterRealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var imageDrawer = new ImageDrawer();

            PaperPrinter paperPrinter = new PaperPrinter();
            imageDrawer.DrawWith(paperPrinter);

            CanvasPainter canvasPainter = new CanvasPainter();
            IPrinter imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);
            
            imageDrawer.DrawWith(imagePrinter);
            Console.Read();
        }
    }
}