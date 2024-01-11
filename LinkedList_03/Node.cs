using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_03
{
    internal class Node
    {
        /*Automatically Implemented Property*/
        public int Value { get; set; }
        public Node Host { get; set; }

        /*ctor*/
        public Node()
        {
            Host = null;
        }

        public Node(int value)
        {
            Value = value;
            Host = null;
        }
    }
}
