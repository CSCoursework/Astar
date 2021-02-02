using System;
using System.Collections.Generic;
using System.Linq;

namespace Astarfrompsuedo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] map = new string[]
            {
                "+------+",
                "|      |",
                "|A X   |",
                "| XX   |",
                "|   X  |",
                "| B    |",
                "|      |",
                "+------+",
            };

            foreach (var line in map)
                Console.WriteLine(line);
            Node current = null;
            Node start = methods.newnode(1, 2);
            Node target = methods.newnode(2, 5);
            List<Node> openList = new List<Node>();
            List<Node> closedList = new List<Node>();
            int g = 0;
            openList.Add(start);

            while (openList.Count > 0)
            {
                int lowest = openList.Min(l => l.F);
                current = openList.First(l => l.F == lowest);

                closedList.Add(current);

                openList.Remove(current);

                if (closedList.FirstOrDefault(l => l.X == target.X && l.Y == target.Y) != null)
                    break;

                List<Node> Neighbours = methods.GetNeighbours(current.X, current.Y, map);
                g++;

                foreach (Node neighbour in Neighbours)
                {
                    if (closedList.FirstOrDefault(l => l.X == neighbour.X
                            && l.Y == neighbour.Y) != null)
                        continue;
                    if (openList.FirstOrDefault(l => l.X == neighbour.X
                            && l.Y == neighbour.Y) == null)
                    {
                        neighbour.G = g;
                        neighbour.H = methods.GetH(neighbour.X, neighbour.Y, target.X, target.Y);
                        neighbour.F = neighbour.G + neighbour.H;
                        neighbour.Parent = current;
                        openList.Insert(0, neighbour);
                    }
                    else
                    {
 
                        if (g + neighbour.H < neighbour.F)
                        {
                            neighbour.G = g;
                            neighbour.F = neighbour.G + neighbour.H;
                            neighbour.Parent = current;
                        }
                    }
                }
            }

            if (current != null)
            {
                Console.WriteLine("Pathfound");
            }
            Console.ReadLine();
        }
    }
}
