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
    }
}
