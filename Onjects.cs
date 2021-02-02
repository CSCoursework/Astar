using System;
using System.Collections.Generic;
using System.Text;

namespace Astarfrompsuedo
{
    class Node 
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int F { get; set; }
        public int G { get; set; }
        public int H { get; set; }
        public Node Parent { get; set; }

    }
}
