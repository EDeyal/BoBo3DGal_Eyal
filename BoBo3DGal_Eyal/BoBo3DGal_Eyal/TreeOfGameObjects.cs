using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    class TreeOfGameObjects : IEnumerable
    {
        List<Node> _gameObjectsNodes = new List<Node>();
        public TreeOfGameObjects(List<Node> gameObjects)
        {
            _gameObjectsNodes = new List<Node>(gameObjects.Count);
            for (int i = 0; i < gameObjects.Count; i++)
            {
                _gameObjectsNodes[i] = gameObjects[i];
            }
            //not sure needed for list
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public TreeEnumerator GetEnumerator()
        {
            return new TreeEnumerator(_gameObjectsNodes);
        }
        //public GameObject FindGameObjectByName(string name)
        //{
        //    GameObject wantedObject = null;
        //    foreach (var rootNode in _gameObjectsNodes)
        //    {
        //        rootNode.FindGameObjectInChildren(name);
        //        if (wantedObject != null)
        //            return wantedObject;
        //    }
        //    return null;
        //}
    }
}
