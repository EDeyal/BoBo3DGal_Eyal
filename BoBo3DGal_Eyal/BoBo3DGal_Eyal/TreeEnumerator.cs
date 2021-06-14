using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    class TreeEnumerator : IEnumerator<Node>//treeStructure of nodes that has gameObjects
    {
        int indicator = 0;
        public Node Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public bool MoveNext()
        {
            indicator++;
            throw new NotImplementedException();
        }
        public void Reset()
        {
            //move to root node
            throw new NotImplementedException();
        }
        //go on first node, after that go down on all nodes if you get to a leaf, go back

        //  root       1
        //           /   \
        //          2     5
        //         / \   / \
        //  leaf  3   4 6
        //             /
        //            7
    }
}
