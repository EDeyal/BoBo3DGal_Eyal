﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BoBo3DGalEyalSpaceShooter
{
    public static class SubscriptionManager
    {
        #region Fields
        static Updatable<IUpdatable> _updatable = new Updatable<IUpdatable>();
        static Startable<IStartable> _startable = new Startable<IStartable>();
        #endregion
        #region Methods
        public static void AddSubscriber<T>(T item)
        {
            if (item == null)
            {
                Console.WriteLine("Error in AddSubscriber");
                return;
            }
            switch (true)
            {
                case true when typeof(T) == typeof(IUpdatable):
                    _updatable.AddUpdatable(item as IUpdatable);
                    break;
                case true when typeof(T) == typeof(IStartable):
                    _startable.AddStartable(item as IStartable);
                    break;
                default:
                    Console.WriteLine("Error in AddSubscriber");
                    break;
            }
        }
        public static void RemoveSubscriber<T>(T item)
        {
            if (item == null)
            {
                Console.WriteLine("Error in RemoveSubscriber");
            }
            switch (true)
            {
                case true when typeof(T) == typeof(IUpdatable):
                    _updatable.RemoveUpdatable(item as IUpdatable);
                    break;
                case true when typeof(T) == typeof(IStartable):
                    _startable.RemoveStartable(item as IStartable);
                    break;
                default:
                    Console.WriteLine("Error in RemoveSubscriber");
                    break;
            }
        }
        public static void ActivateAllSubscribersOfType<T>()
        {
            switch (true)
            {
                case true when typeof(T) == typeof(IUpdatable):
                _updatable.RunUpdate();
                    break;
                case true when typeof(T) == typeof(IStartable):
                    _startable.StartAll();
                    break;
                default:
                    Console.WriteLine("Error in ActivateAllSubscribersOfType");
                    break;
            }
        }
        #endregion
    }
}

