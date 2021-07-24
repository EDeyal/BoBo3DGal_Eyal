﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BoBo3DGalEyalSpaceShooter
{
    class Startable<T> where T: IStartable
    {
        #region Fields
        List<T> _startableList = new List<T>(5);
        #endregion
        #region Properties
        public List<T> GetStartableList => _startableList;
        #endregion
        #region Methods
        public void AddStartable(T startableClass)
        {
            if(_startableList.Contains(startableClass))
            {
                Console.WriteLine("Class already exists not adding to StartableList");
                return;
            }
            _startableList.Add(startableClass);
        }
        public void RemoveStartable(T startableClass)
        {
            if(!_startableList.Contains(startableClass))
            {
                Console.WriteLine("Class not in StartableList");
                return;
            }
            _startableList.Remove(startableClass);
        }
        public void StartAll()
        {
            foreach (var startable in _startableList)
            {
                startable.start();
            }
        }
        #endregion
    }
}
