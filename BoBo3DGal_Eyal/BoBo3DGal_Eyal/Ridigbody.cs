using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Ridigbooty : Component
    {
        #region Fields
        private float _velocity;
        private bool _useGravity;
        private float _gravityScale;
        #endregion

        #region Properties
        public float Velocity { get => _velocity; set => _velocity = value; }
        public bool UseGravity { get => _useGravity; set => _useGravity = value; }
        public float GravityScale { get => _gravityScale; set => _gravityScale = value; }
        #endregion

        public Vector3 AddForce()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyConstantForce(Vector3 vector3, float amount)
        {
            throw new System.NotImplementedException();
        }
    }
}