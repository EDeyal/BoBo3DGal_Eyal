using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BoBo3DGalEyalSpaceShooter
{
    class Model3D : Game, Icomponent
    {
        Model _model;

        public Model3D(string modelName)
        {
            _model = Content.Load<Model>(modelName);
        }
    }
}
