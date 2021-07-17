using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class BoxCollider : Component
    {
        #region Fields
        // distance from center to horizontal edge
        private float _cX;
        // distance from center to vertical edge
        private float _cY;
        // distance from center to diagonal edge
        private float _cZ;

        private float _boxTop;
        private float _boxBottom;
        private float _boxLeft;
        private float _boxRight;
        private float _boxFront;
        private float _boxBack;
        private Vector3 _scale = new Vector3(1,1,1);
        private Vector3 _position = new Vector3();
        #endregion

        #region Properties
        public float CX { get => _cX; set => _cX = value; }
        public float CY { get => _cY; set => _cY = value; }
        public float CZ { get => _cZ; set => _cZ = value; }
        public float BoxTop { get => _boxTop; set => _boxTop = value; }
        public float BoxBottom { get => _boxBottom; set => _boxBottom = value; }
        public float BoxLeft { get => _boxLeft; set => _boxLeft = value; }
        public float BoxRight { get => _boxRight; set => _boxRight = value; }
        public float BoxFront { get => _boxFront; set => _boxFront = value; }
        public float BoxBack { get => _boxBack; set => _boxBack = value; }
        public Vector3 Scale { get => _scale; set => _scale = value; }
        public Vector3 Position { get => _position; set => _position = value; }
        #endregion

        BoxCollider(GameObject gameObject, Vector3 size)
        {
            gameObject.Transform
            // determain distance of every side from center
            CX = size.X / 2;
            CY = size.Y / 2;
            CZ = size.Z / 2;

            // set the exact points of box
            BoxLeft = Position.X - CX;
            BoxRight = Position.X + CX;
            BoxTop = Position.Y - CY;
            BoxBottom = Position.Y + CY;
            BoxFront = Position.Z - CZ;
            BoxBack = Position.Z + CZ;
        }
    }
}