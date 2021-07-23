using System;
using System.Collections;
using System.Collections.Generic;


namespace BoBo3DGal_Eyal
{
    public class TreeOfGameObjects : IEnumerable<Node>
    {

        #region Fields
        Node _root;
        #endregion

        #region Fields
        public Node Root => _root;
        #endregion

        public TreeOfGameObjects(Node root)
        {
            _root = root;
        }
        public IEnumerator<Node> GetEnumerator()
        {
            return new TreeDepthEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
