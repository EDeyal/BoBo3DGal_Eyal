using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Transform : Component
    {

        #region Fields
        GameObject _gameObject;
        Vector3 _position;
        Vector3 _scale;
        #endregion

        #region Properties
        public GameObject GetSetGameObject { get => _gameObject; set => _gameObject = value; }
        public Vector3 Position { get => _position; set => _position = value; }
        public Vector3 Scale { get => _scale; set => _scale = value; }
        #endregion

        public Transform(Vector3 newPosition, Vector3 newScale)
        {
            Position = newPosition;
            Scale = newScale;
            Console.WriteLine($"New Transform{this}");
        }

        #region Overrides
        public override string ToString()
        {
            return $"Position: {Position}," + $" Scale: {Scale}";
        }
        #endregion
    }
}