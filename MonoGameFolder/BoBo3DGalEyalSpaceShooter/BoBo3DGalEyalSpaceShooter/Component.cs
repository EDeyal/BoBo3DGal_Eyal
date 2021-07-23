﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGalEyalSpaceShooter
{
    public abstract class Component : Icomponent
    {
        #region Fields
        GameObject _gameObject;
        Transform _transform;
        
        string _name;
        #endregion

        #region Properties
        public GameObject GameObjectP { get => _gameObject; set => _gameObject = value; }
        public Transform TransformP { get => _transform; set => _transform = value; }
        public string Name { get => _name; set => _name = value; }
        #endregion

        #region Methods

        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"{Name}" + Environment.NewLine;
        }
        #endregion
    }
}