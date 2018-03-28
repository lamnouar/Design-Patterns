﻿using System;

namespace CommandPattern
{
    /// <summary>
    /// Receiver
    /// </summary>
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            Console.WriteLine("Light is Off");
        }
    }
}
