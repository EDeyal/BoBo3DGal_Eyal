using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class BoxCollider : Component
    {
        #region Fields
        GameObject _parentGameObject;
        readonly Vector3 _size = new Vector3(1,1,1);
        #endregion
        #region Properties
        Vector3 GetSize => _size;
        public override GameObject GetSetParentGameObject { get => _parentGameObject; set => _parentGameObject = value; }
        #endregion
        public override string ToString()
        {
            return _parentGameObject.Name + " BoxCollider";
        }
    }
}