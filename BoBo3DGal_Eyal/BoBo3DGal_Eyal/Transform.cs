using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public class Transform : Component
    {
        Vector3 _position;

        public Vector3 Position { get => _position; set => _position = value; }
    }
}