﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRealExample.Devies
{
    class CanvasPainter : IPainter
    {
      public void Paint()
        {
            Console.WriteLine("Рисуем на хосте");
        }
    }
}