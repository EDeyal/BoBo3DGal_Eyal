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
        List<GameObject> _gameObjects;
        #endregion
        #region Properties
        GameObject GameObject => _gameObject;
        public Vector3 Position { get => _position; set => _position = value; }
        List<GameObject> GameObjects { get => _gameObjects; set => _gameObjects = value; } 
        #endregion
    }
}