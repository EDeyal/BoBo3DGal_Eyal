using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    public class Node//class that holds one gameObject and knows the location on the tree
        //leaf, root, chield, parant
    {
        public Node(GameObject gameObject, Node parent)
        {
            _gameObject = gameObject;
            _gameObject.GetSetParentNode = this;
            _children = new List<Node>();
            if(parent != null)
            {
                _parent = parent;
                parent.AddChild(this);
            }
        }
        #region Fields
        List<Node> _children;
        Node _parent;
        GameObject _gameObject;
        bool _isRoot;
        //bool _isLeaf;
        //bool _isChild;
        //bool _isParent;
        #endregion
        #region Properties
        public GameObject GetGameObject => _gameObject;
        public bool GetIsRoot => _isRoot;
        public List<Node> GetChildren => _children;
        public Node GetSetParant { get => _parent; set => _parent = value; }
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
        public void AddChild(Node child)
        {
            child.GetSetParant = this;
            _children.Add(child);
        }
        public void EnableNode(Node node)
        {
            Console.WriteLine($"Enabling {node.ToString()}");
            node.GetGameObject.EnableGameObject();
            foreach (var child in node.GetChildren)
            {
                EnableNode(child);
            }
        }
        public override string ToString()
        {
            return GetGameObject.Name.ToString();
        }
    }
}
