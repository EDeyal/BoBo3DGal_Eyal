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
    }
}
