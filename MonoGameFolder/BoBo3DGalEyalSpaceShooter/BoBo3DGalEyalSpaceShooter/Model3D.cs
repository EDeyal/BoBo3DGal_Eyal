using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BoBo3DGalEyalSpaceShooter
{
    class Model3D : Component, Icomponent
    {
        Model _model;
        GameObject parent;
        public Model3D(GameObject parentObject, string modelName)
        {
            _model = Content.Load<Model>(modelName);
            parent = parentObject;

        }
    }
}
