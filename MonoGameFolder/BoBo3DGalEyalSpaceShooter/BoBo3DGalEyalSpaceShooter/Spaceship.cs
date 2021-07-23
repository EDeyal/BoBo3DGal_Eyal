using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BoBo3DGalEyalSpaceShooter
{
    class Spaceship : Game
    {
        Model _pizzaCar;

        public Spaceship()
        {
            _pizzaCar = Content.Load<Model>("Pizza_Car");
        }

        public void SomeMethod()
        {

        }
    }
}
