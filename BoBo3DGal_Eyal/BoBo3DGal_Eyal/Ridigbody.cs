using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Ridigbooty : Component
    {
        #region Fields
        string _name;
        float _velocity;
        float _gravityScale;
        float _mass;
        Vector3 _position;
        bool _useGravity;
        bool _isKinematic;
        #endregion

        #region Properties
        public string Name { get => _name; set => _name = value; }
        public float Velocity { get => _velocity; set => _velocity = value; }
        public float GravityScale { get => _gravityScale; set => _gravityScale = value; }
        public float Mass { get => _mass; set => _mass = value; }
        public Vector3 Position { get => _position; set => _position = value; }
        public bool UseGravity { get => _useGravity; set => _useGravity = value; }
        public bool IsKinematic { get => _isKinematic; set => _isKinematic = value; }
        #endregion

        public Ridigbooty(GameObject gameobject)
        {
            Name = gameobject.Name;
        }

        #region Methods
        public Vector3 AddForce()
        {
            throw new System.NotImplementedException();
        }

        public Vector3 MovePosition()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyConstantForce(Vector3 vector3, float amount)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}