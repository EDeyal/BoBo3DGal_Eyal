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
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public GameObject FindGameObjectByName(string name)
        {
            GameObject wantedObject = null;
            foreach (var rootNode in _gameObjectsNodes)
            {
                rootNode.FindGameObjectInChildren(name);
                if (wantedObject != null)
                    return wantedObject;
            }
            return null;
        }
    }
}
