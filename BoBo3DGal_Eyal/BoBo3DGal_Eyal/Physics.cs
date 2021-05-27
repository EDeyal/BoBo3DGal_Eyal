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

        /*public static bool AABB(BoxCollider boxA, BoxCollider boxB)
        {
            return boxA.Left < boxB.Right &&
                    boxA.Right > boxB.Left &&
                    boxA.Top < boxB.Bottom &&
                    boxA.Bottom > boxB.Top;
        }*/

        public static void OnCollision()
        {

        }
        public static void OnCollisionStart()
        {

        }

        public static void OnCollisionEnd()
        {

        }
    }
}