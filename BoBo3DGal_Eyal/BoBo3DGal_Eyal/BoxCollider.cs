﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class BoxCollider : Component
    {
        #region Fields
        string _tag;
        // distance from center to horizontal edge
        float _cX;
        // distance from center to vertical edge
        float _cY;
        // distance from center to diagonal edge
        float _cZ;

        float _boxTop;
        float _boxBottom;
        float _boxLeft;
        float _boxRight;
        float _boxFront;
        float _boxBack;
        Vector3 _scale = new Vector3(1,1,1);
        Vector3 _position = new Vector3();

        bool _isEnabled = true;
        #endregion

        #region Properties
        public string Tag { get => _tag; set => _tag = value; }
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
        public bool IsEnabled { get => _isEnabled; set => _isEnabled = value; }
        #endregion

        public BoxCollider(GameObject gameObject)
        {
            Tag = gameObject.Name + " Colider";
            float objX = gameObject.GetComponent<Transform>().Position.X;
            float objY = gameObject.GetComponent<Transform>().Position.Y;
            float objZ = gameObject.GetComponent<Transform>().Position.Z;

            //width
            float objW = gameObject.GetComponent<Transform>().Scale.X;
            //height
            float objH = gameObject.GetComponent<Transform>().Scale.Y;
            //depth
            float objD = gameObject.GetComponent<Transform>().Scale.Z;

            //determain distance of every side from center
            CX = objW / 2;
            CY = objH / 2;
            CZ = objD / 2;

            //set colider posiotion to object positino
            Position = new Vector3(objX, objY, objZ);

            // set the exact points of box
            BoxLeft = Position.X - CX;
            BoxRight = Position.X + CX;
            BoxTop = Position.Y - CY;
            BoxBottom = Position.Y + CY;
            BoxFront = Position.Z - CZ;
            BoxBack = Position.Z + CZ;
        }

        #region Methods
        public void Disable()
        {
            if (IsEnabled)
            {
                IsEnabled = false;
            }
        }
        public void Enable()
        {
            if (!IsEnabled)
            {
                IsEnabled = true;
            }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"{Tag}";
        }
        #endregion
    }
}