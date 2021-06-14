using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    class Node//class that holds one gameObject and knows the location on the tree
        //leaf, root, chield, parant
    {
        List<Node> _children = new List<Node>();
        Node _parent;
        GameObject _gameObject;
        bool isRoot;
        bool isLeaf;
        bool isChild;
        bool isParent;
        public GameObject FindGameObjectInChildren(string name)
        {
            //check if name is acceptable or not null
            if (name == _gameObject.Name)
            {
                return _gameObject;
            }
            GameObject wantedObject = null;
            foreach (var node in _children)
            {
                wantedObject = node.FindGameObjectInChildren(name);
                if(wantedObject != null)
                {
                    return wantedObject;
                }
            }
            return null;
        }
    }
}
