﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraVert
{
    internal class Plant
    {
        public string Species { get; set; }
        public int LightNeeds { get; set; }
        public double AskingPrice { get; set; }
        public string City { get; set; }
        public int ZIP { get; set; }
        public bool Sold { get; set; }
    }
}
