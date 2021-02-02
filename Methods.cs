using System;
using System.Collections.Generic;
using System.Linq;

namespace Astarfrompsuedo
{


    class methods
    {
        public static Node newnode(int x, int y) 
        {
            Node toreturn = new Node();
            toreturn.X = x;
            toreturn.Y = y;
            return toreturn;
        }
        public static List<Node> GetNeighbours(int x, int y, string[] map)
        {
            List<Node> possiblelocations = new List<Node>()
            {newnode( x, y - 1 ),newnode(x,y + 1),newnode(x - 1,y),newnode (x + 1,y )};
            return possiblelocations.Where(l => map[l.Y][l.X] == ' ' || map[l.Y][l.X] == 'B').ToList();
        }

        public static int GetH(int x, int y, int targetX, int targetY)
        {
            return (targetX - x) + (targetY - y);
        }

    }
}
