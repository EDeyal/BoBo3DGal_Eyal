using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    public class Node//class that holds one gameObject and knows the location on the tree
        //leaf, root, chield, parant
    {
        public Node(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        #region Fields
        List<Node> _children = new List<Node>();
        Node _parent;
        GameObject _gameObject;
        bool _isRoot;
        bool _isLeaf;
        bool _isChild;
        bool _isParent;
        #endregion
        #region Properties
        public GameObject GetGameObject => _gameObject;
        public bool GetIsRoot => _isRoot;
        #endregion
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
