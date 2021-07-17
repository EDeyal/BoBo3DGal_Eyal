using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BoBo3DGal_Eyal
{
    public static class Physics
    {
        public static List<BoxCollider> AllBoxColliders = new List<BoxCollider>(20);

        private static float _gravity = 9.80665f;

        public static float Gravity { get => _gravity; set => _gravity = value; }

        public static bool AABB(BoxCollider boxA, BoxCollider boxB)
        {
            return boxA.BoxLeft < boxB.BoxRight &&
                    boxA.BoxRight > boxB.BoxLeft &&
                    boxA.BoxTop < boxB.BoxBottom &&
                    boxA.BoxBottom > boxB.BoxTop;
        }

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