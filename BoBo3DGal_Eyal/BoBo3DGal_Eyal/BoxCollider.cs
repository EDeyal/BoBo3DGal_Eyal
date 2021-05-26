using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class BoxCollider : Component
    {
        #region Fields
        readonly Vector3 _size = new Vector3(1,1,1);
        #endregion
        #region Properties
        Vector3 GetSize => _size;
        #endregion
        public void OnCollision()
        {

        }
        public void OnCollisionStart()
        {

        }

        public void OnCollisionEnd()
        {

        }
    }
}