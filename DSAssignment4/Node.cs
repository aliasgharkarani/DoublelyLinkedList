using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAssignment4
{
    class Node
    {
        public string[] data = new string[3] { "PF", "90", "8999" };
        public Node NextNode { get; set; }
        public Node PreviousNode { get; set; }

        public Node(string[] _data)
        {
            data[0] = _data[0];
            data[1] = _data[1];
            data[2] = _data[2];
        }

        //public void EditData(int _data)
        //{
        //    data = _data;
        //}
        //public int GetData()
        //{
        //    return data;
        //}
        public void SetNextNode(Node _nextNode)
        {
            NextNode = _nextNode;
        }
        public Node GetNextNode()
        {
            return NextNode;
        }
    }
}
