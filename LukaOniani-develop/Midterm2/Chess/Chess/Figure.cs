using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public abstract class Figure
    {
        public string Color { get; set; }
        public Figure(string color)
        {
            Color = color;
        }



        public abstract void Move();

        public abstract void Kill();


        
    }
}
