﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BoBo3DGalEyalSpaceShooter
{
    class InputManager : IUpdatable, IStartable
    {
        public InputManager()
        {
            SubscriptionManager.AddSubscriber<IStartable>(this);
            SubscriptionManager.AddSubscriber<IUpdatable>(this);
        }

        public void start()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
