using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    public class TreeEnumerator : IEnumerator<Node>//treeStructure of nodes that has gameObjects
    {
        public TreeEnumerator(List<Node> nodeList)
        {
            _rootlist = nodeList;
        }
        #region Field

        Node _root;
        List<Node> _rootlist;
        Node _currentNode;
        GameObject _wantedObject = null;
        string _searchedName;
        int _rootPosition = -1;
        #endregion
        #region Properties
        //public Node GetRoot => _root;
        public Node Current
        {
            //Gets the element in the collection at the current position of the enumerator.
            get
            {
                try
                {
                    return _rootlist[_rootPosition];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        #endregion
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {
            //Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
            throw new NotImplementedException();
        }
        public bool MoveNext()//run the algorithem for every root?
        {
            //Advances the enumerator to the next element of the collection.

            _rootPosition++;
            return (_rootPosition < _rootlist.Count);
        }
        public void Reset()//reset to first root?
        {
            //Sets the enumerator to its initial position, which is before the first element in the collection.
            _rootPosition = -1;
        }

        //public GameObject SearchGameObject(Node root, string gameObjectName)
        //{
        //    _root = root;
        //    _searchedName = gameObjectName;
        //    _wantedObject = SearchTree();
        //    return _wantedObject;
        //}
        //GameObject SearchTree()
        //{
        //    GameObject gameObject = null;
        //    gameObject = SearchRoot();
        //    if(gameObject != null && gameObject.Name == _searchedName)
        //    {
        //        return gameObject;
        //    }
        //    else
        //    {
        //        gameObject = SearchChildren();
        //        if (gameObject != null && gameObject.Name == _searchedName)
        //        {
        //            return gameObject;
        //        }
        //    }
        //    return null;
        //}
        //GameObject SearchRoot()
        //{
        //    _currentNode = _root;
        //    if (_currentNode.GetIsRoot == true)
        //    {
        //        if (_searchedName == _root.GetGameObject.Name)
        //        {
        //            return _root.GetGameObject;
        //        }
        //        Console.WriteLine("Not Root");
        //    }
        //    return null;
        //}
        //GameObject SearchChildren()
        //{

        //}

        //go on first node, after that go down on all nodes if you get to a leaf, go back

        //  root       1
        //           /   \
        //          2     5
        //         / \   / \
        //  leaf  3   4 6
        //             /
        //            7
        //check root node if it is the game object
        //if not move next to second node and start recursive action per level of the hyrarchi
    }
}
