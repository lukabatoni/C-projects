﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class King : Figure

    {
        public King(string color) : base(color) 
        {
            Color = color;
        }

        public override void Kill()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
