﻿using DesignPatterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Structural.Adapter
{
    internal class Adapter : OldClass, INewTarget
    {
        public void NewMethod()
        {
            oldMethod();

            var i = 0;
            
            var p = 9;
        }
    }
}
