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
            //_gameObject = gameObject;
            Console.WriteLine($"New Transform{this}");
        }
        #region Fields
        GameObject _gameObject;
        Vector3 _position;
        //List<GameObject> _gameObjects;
        #endregion
        #region Properties
        public GameObject GetSetGameObject { get => _gameObject; set => _gameObject = value; }
        public Vector3 Position { get => _position; set => _position = value; }
        //List<GameObject> GameObjects { get => _gameObjects; set => _gameObjects = value; } 
        #endregion
        public override string ToString()
        {
            return $"{Position.ToString()}";
        }
    }
}