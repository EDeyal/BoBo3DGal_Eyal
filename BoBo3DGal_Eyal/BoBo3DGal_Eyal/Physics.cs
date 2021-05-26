using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoBo3DGal_Eyal
{
    public static class Physics
    {
        private static float _gravity;

        public static float Gravity { get => _gravity; set => _gravity = value; }
    }
}