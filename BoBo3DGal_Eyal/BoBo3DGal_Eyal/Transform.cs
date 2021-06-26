using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Transform : Component
    {
        public Transform(Vector3 newPosition)
        {
            Position = newPosition;
            Console.WriteLine($"New Transform{this}");
        }
        #region Fields
        GameObject _parentGameObject;
        Vector3 _position;
        #endregion
        #region Properties
        public override GameObject GetSetParentGameObject { get => _parentGameObject; set => _parentGameObject = value; }
        public Vector3 Position { get => _position; set => _position = value; }
        #endregion
        public override string ToString()
        {
            return $"{Position}";
        }
    }
}