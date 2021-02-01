using System;
using System.Collections.Generic;
using System.Text;

namespace Astarfrompsuedo
{
    class Node
    {
        public int f { get; set; }
        public int g { get; set; }
        public int h { get; set; }
        public List<Node> neighbours { get; set; }
    }

    class methods
    {

        static Node astar(Node startnode)
        {
            List<Node> openlist = new List<Node>();
            openlist.Add(startnode);
            List<Node> closedlist = new List<Node>();


            Node currentnode = new Node();
            Node destination = new Node();
            Node nextnode = new Node();
            while (currentnode != destination)
            {
                nextnode = openlist[1];
                foreach (var node in openlist)
                {
                    if (node.f < nextnode.f) { nextnode = node; }
                }

                closedlist.Add(currentnode);

                foreach (var neighbour in currentnode.neighbours) {
                    if (neighbour.g < currentnode.g && closedlist.Contains(neighbour)) { }
                }


            }
        }
    }
}
