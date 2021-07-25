﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BoBo3DGalEyalSpaceShooter
{
    class Updatable<T> where T : IUpdatable
    {
        #region Fields
        List<T> _updatablesList = new List<T>(5);
        #endregion
        #region Properties
        public List<T> GetUpdatableList => _updatablesList;
        #endregion
        #region Methods
        public void AddUpdatable(T updatableClass)
        {
            if (_updatablesList.Contains(updatableClass))
            {
                Console.WriteLine("Class already exists not adding to updateableList");
                return;
            }
            _updatablesList.Add(updatableClass);
        }
        public void RemoveUpdatable(T updatableClass)
        {
            if (!_updatablesList.Contains(updatableClass))
            {
                Console.WriteLine("Class not in UpdatableList");
                return;
            }
            _updatablesList.Remove(updatableClass);
        }
        public void RunUpdate()
        {
            foreach (var updatable in _updatablesList)
            {
                updatable.Update();
            }
        }
        #endregion
    }
}
