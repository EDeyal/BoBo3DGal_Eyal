using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    class Node//class that holds one gameObject and knows the location on the tree
        //leaf, root, chield, parant
    {
        GameObject _gameObject;
        bool isRoot;
        bool isLeaf;
        bool isChild;
        bool isParent;
    }
}
