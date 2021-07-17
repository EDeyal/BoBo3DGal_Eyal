using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BoBo3DGal_Eyal
{
    public static class Physics
    {
        #region Fields
        static List<BoxCollider> _allBoxColliders = new List<BoxCollider>(20);
        static float _gravity = 9.80665f;
        static bool _usePhysics = true;
        #endregion

        #region Properties
        public static List<BoxCollider> AllBoxColliders { get => _allBoxColliders; set => _allBoxColliders = value; }
        public static float Gravity { get => _gravity; set => _gravity = value; }
        public static bool UsePhysics { get => _usePhysics; set => _usePhysics = value; }
        #endregion

        #region Methods
        public static bool AABB(BoxCollider boxA, BoxCollider boxB)
        {
            return boxA.BoxLeft < boxB.BoxRight &&
                   boxA.BoxRight > boxB.BoxLeft &&
                   boxA.BoxTop < boxB.BoxBottom &&
                   boxA.BoxBottom > boxB.BoxTop;
        }

        public static void CheckCollision()
        {
            foreach (BoxCollider colider in AllBoxColliders)
            {
                if (!colider.IsEnabled)
                    continue;

                foreach (BoxCollider anotherColider in AllBoxColliders)
                {
                    if (!colider.IsEnabled)
                        continue;

                    if (AABB(colider, anotherColider))
                        Console.WriteLine(colider + " and " + anotherColider + " are coliding");
                }
            }
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
        #endregion

        #region Overrides
        #endregion
    }
}