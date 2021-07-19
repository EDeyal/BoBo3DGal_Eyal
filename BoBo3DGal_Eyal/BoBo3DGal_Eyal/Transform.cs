using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Transform : Component
    {

        #region Fields
        string _name;
        Vector3 _position;
        Vector3 _scale;
        #endregion

        #region Properties
        public string Name { get => _name; set => _name = value; }
        public Vector3 Position { get => _position; set => _position = value; }
        public Vector3 Scale { get => _scale; set => _scale = value; }
        #endregion

        public Transform(GameObject gameObject)
        {
            Name = gameObject.Name;
            Position = new Vector3(0, 0, 0);
            Scale = new Vector3(1, 1, 1);
            Console.WriteLine($"New Transform{this}");
        }

        #region Overrides
        public override string ToString()
        {
            return $"Transform of {Name}" + Environment.NewLine
                 + $"Position: {Position}," + Environment.NewLine
                 + $" Scale: {Scale}";
        }
        #endregion
    }
}