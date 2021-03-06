﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingThings
{
    class Celsius
    {
        public float Temp { get; private set; }
        public Celsius(float temp)
        {
            Temp = temp;
        }
        //Vi ska skapa en explicit typkonvertering som returnerar en Farenheit

        public static implicit operator Farenheit(Celsius celsius)
        {
            return new Farenheit((9.0f/5.0f)*celsius.Temp + 32);
        }
        
    }
}
